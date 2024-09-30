<script setup lang="ts">
import AnimeGrid from "./components/AnimeGrid.vue";
import schedule from "./schedule.json";
</script>

<template>
  <div class="max-w-[84rem] mx-auto my-8">
    <h1 class="text-center font-black">
      <span class="text-5xl">Anime Releases</span>
      <br />
      <span class="text-7xl text-cyan-400">Fall 2024</span>
    </h1>

    <AnimeGrid />
    <footer class="flex justify-between mt-8 items-center text-gray-400">
      <p>
        Source: {{ schedule.Source }}, retrieved at {{ computedRetrievedTime }}.
      </p>
      <div>
        <div class="flex items-center">
          Created by
          <div
            class="bg-[url('assets/pfp.png')] bg-cover w-8 h-8 mx-1 rounded-md"
          ></div>
          enonibobble, inspired by u/AnimeSamaDesu.
        </div>
      </div>
    </footer>
  </div>
</template>

<script lang="ts">
export default {
  computed: {
    computedRetrievedTime() {
      const date = new Date(schedule.RetrievedAt);

      const formatter = new Intl.DateTimeFormat("en-US", {
        year: "numeric",
        month: "2-digit",
        day: "2-digit",
        hour: "2-digit",
        minute: "2-digit",
        timeZone: "UTC",
        hour12: false,
      });

      const formattedParts: Intl.DateTimeFormatPart[] =
        formatter.formatToParts(date);
      const dateParts: { [key: string]: string } = {};
      formattedParts.forEach((part: Intl.DateTimeFormatPart) => {
        dateParts[part.type] = part.value;
      });

      return `${dateParts.day}/${dateParts.month}/${dateParts.year} ${dateParts.hour}:${dateParts.minute} (UTC)`;
    },
  },
};
</script>
