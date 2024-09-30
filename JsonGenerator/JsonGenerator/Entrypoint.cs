using System.Diagnostics;
using System.Text.Json;
using JsonGenerator.AniList;
using Microsoft.Extensions.DependencyInjection;
using StrawberryShake;

namespace JsonGenerator;

public class Entrypoint
{
    public static async Task Main()
    {
        var serviceCollection = new ServiceCollection();

        serviceCollection
            .AddAnilistClient()
            .ConfigureHttpClient(client =>
                client.BaseAddress = new Uri("https://graphql.anilist.co")
            );

        var services = serviceCollection.BuildServiceProvider();

        var client = services.GetRequiredService<IAnilistClient>();

        var page = 1;

        var items = new List<IGetSeasonals_Page_Media>(50);
        var isPages = true;
        while (isPages)
        {
            var res = await client.GetSeasonals.ExecuteAsync(page);
            res.EnsureNoErrors();

            Debug.Assert(res.Data != null);

            var data = res.Data.Page!;

            isPages = data.PageInfo!.HasNextPage!.Value;
            page++;

            items.AddRange(data.Media!);
        }

        var dict = new Dictionary<DateOnly, FrontendDateEntry>();
        var mostPopular = items.Where(x => x.BannerImage != null).MaxBy(x => x.Popularity);

        foreach (
            var itemGroup in items
                .Where(item =>
                    item.StartDate != null
                    && item.StartDate!.Day != null
                    && item.StartDate!.Month != null
                )
                .GroupBy(item => new DateOnly(
                    item.StartDate!.Year!.Value,
                    item.StartDate.Month!.Value,
                    item.StartDate.Day!.Value
                ))
        )
        {
            var mostPopularOfDate =
                itemGroup.Where(x => x.BannerImage != null).MaxBy(x => x.Popularity)
                ?? itemGroup.MaxBy(x => x.Popularity);

            Debug.Assert(mostPopularOfDate != null);

            var banner = mostPopularOfDate.BannerImage;

            if (banner == null || itemGroup.Count() <= 4)
            {
                banner = mostPopularOfDate.CoverImage!.ExtraLarge!;
            }

            var info = new FrontendDateEntry()
            {
                StartDate = itemGroup.Key,
                BannerUrl = banner
            };

            dict.Add(itemGroup.Key, info);

            foreach (var item in itemGroup.OrderBy(x => x.NextAiringEpisode?.AiringAt))
            {
                var name = item.Title!.English ?? item.Title.Romaji;

                Debug.Assert(name != null);

                var animeEntry = name;

                info.Entries.Add(animeEntry);
            }
        }

        var root = new FrontendRoot() { RetrievedAt = DateTime.Now, Entries = dict };

        var json = JsonSerializer.Serialize(
            root,
            new JsonSerializerOptions { WriteIndented = true }
        );

        Console.WriteLine(json);
        Console.ReadLine();
    }
}

public record FrontendRoot
{
    public required DateTime RetrievedAt { get; set; }
    public string Source { get; set; } = "AniList";
    public required Dictionary<DateOnly, FrontendDateEntry> Entries { get; set; }
}

public record FrontendDateEntry
{
    public required DateOnly StartDate { get; set; }
    public required string BannerUrl { get; set; }
    public string BannerPosition { get; set; } = "center center";
    public List<string> Entries { get; } = [];
}
