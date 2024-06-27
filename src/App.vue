<script setup lang="ts">
import AnimeDate from "./components/AnimeDate.vue";
</script>

<template>
  <div class="max-w-[84rem] mx-auto my-8">
    <h1 class="text-center font-black">
      <span class="text-5xl">Anime Releases</span>
      <br />
      <span class="text-7xl text-cyan-400">Summer 2024</span>
    </h1>

    <div class="flex-wrap flex">
      <AnimeDate
        backgroundImageClass="bg-[url('https://s4.anilist.co/file/anilistcdn/media/anime/cover/large/bx173584-nyZElmr8218W.jpg')]"
        date="2024-06-26"
        :listItems="[
          'The Strongest Magician in the Demon Lord\'s Army was a Human',
        ]"
      />
      <AnimeDate
        backgroundImageClass="bg-[url('https://s4.anilist.co/file/anilistcdn/media/anime/banner/166710-pr7H0NvG6QHN.jpg')]"
        date="2024-06-27"
        :listItems="['Suicide Squad ISEKAI']"
      />
      <AnimeDate
        backgroundImageClass="bg-[url('https://s4.anilist.co/file/anilistcdn/media/anime/cover/large/bx175450-Wfjd6OqFOn2h.jpg')]"
        date="2024-06-29"
        :listItems="['My Wife Has No Emotion']"
      />
      <AnimeDate
        backgroundImageClass="bg-[url('https://s4.anilist.co/file/anilistcdn/media/anime/cover/large/bx163292-1DkPP4r5UI9Y.jpg')]"
        date="2024-07-01"
        :listItems="[
          'SHY Season 2',
          'The Ossan Newbie Adventurer, Trained to Death by the Most Powerful Party, Became Invincible',
        ]"
      />
      <AnimeDate
        backgroundImageClass="bg-[url('https://s4.anilist.co/file/anilistcdn/media/anime/cover/large/bx174070-mrec0spMuATz.jpg')] bg-top"
        date="2024-07-02"
        :listItems="['TASUKETSU -Fate of the Majority-']"
      />
      <AnimeDate
        backgroundImageClass="bg-[url('https://s4.anilist.co/file/anilistcdn/media/anime/cover/large/bx166531-dAL5MsqDHUkj.jpg')] bg-top"
        date="2024-07-03"
        :listItems="[
          'Oshi no Ko Season 2',
          'Alya Sometimes Hides Her Feelings in Russian',
          'My Deer Friend Nokotan<sup>1</sup>'
        ]"
      />
      <AnimeDate
        backgroundImageClass="bg-[url('https://s4.anilist.co/file/anilistcdn/media/anime/banner/152681-AnePIUjElyvG.jpg')] bg-left"
        date="2024-07-04"
        :listItems="[
          'Days with My Stepsister',
          'Red Cat Ramen',
          'I Parry Everything',
          'The Café Terrace and Its Goddesses Season 2',
          'Pseudo Harem',
          'Twilight Out of Focus',
          'Senpai is an Otokonoko',
          'Failure Frame: I Became the Strongest and Annihilated Everything With Low-Level Spells',
        ]"
      />
      <AnimeDate
        backgroundImageClass="bg-[url('https://s4.anilist.co/file/anilistcdn/media/anime/cover/large/bx163077-PHiTdVlKzXAR.jpg')] bg-top"
        date="2024-07-05"
        :splitAt=5
        :listItems="[
          '2.5 Dimensional Seduction',
          'NieR:Automata Ver1.1a Cour 2',
          'Grendizer U',
          'Dungeon People',
          'Quality Assurance in Another World',
        ]"
      />
      <AnimeDate
        backgroundImageClass="bg-[url('https://s4.anilist.co/file/anilistcdn/media/anime/banner/173295-NjdUsndhRo53.jpg')]"
        date="2024-07-06"
        :listItems="[
          'CARDFIGHT!! VANGUARD Divinez Season 2',
          'Dahlia in Bloom: Crafting a Fresh Start with Magical Tools',
          'A Nobody\'s Way Up to an Exploration Hero',
          'Sakuna: Of Rice and Ruin',
          'The Elusive Samurai',
          'Plus-Sized Elf',
          'SHOSHIMIN: How to become Ordinary',
        ]"
      />
      <AnimeDate
        backgroundImageClass="bg-[url('assets/empty.png')]"
        date=""
        :listItems="[]"
      />
      <AnimeDate
        backgroundImageClass="bg-[url('https://s4.anilist.co/file/anilistcdn/media/anime/banner/175977-sfXIexEc0Jjx.jpg')]"
        date="2024-07-07"
        :splitAt=5
        :listItems="[
          'My Deer Friend Nokotan<sup>1</sup>',
          'Wistoria: Wand and Sword',
          'FAIRY TAIL: 100 Years Quest',
          'HEAD START AT BIRTH',
          'Tower of God 2nd Season',
          'VTuber Legend: How I Went Viral after Forgetting to Turn Off My Stream',
          'Narenare -Cheer for You!-',
          'A Journey Through Another World: Raising Kids While Adventuring'
        ]"
      />
      <AnimeDate
        backgroundImageClass="bg-[url('https://s4.anilist.co/file/anilistcdn/media/anime/cover/large/bx174044-HBvsyKjDVPyO.jpg')] bg-top"
        date="2024-07-08"
        :listItems="[
          'MAYONAKA PUNCH'
        ]"
      />
      <AnimeDate
        backgroundImageClass="bg-[url('https://s4.anilist.co/file/anilistcdn/media/anime/cover/large/bx152137-DOCIkAiaWALu.jpg')] bg-bottom"
        date="2024-07-09"
        :listItems="[
          'The Magical Girl and the Evil Lieutenant Used to Be Archenemies',
          'No Longer Allowed In Another World',
        ]"
      />
      <AnimeDate
        backgroundImageClass="bg-[url('https://s4.anilist.co/file/anilistcdn/media/anime/cover/large/bx167144-tKDxH7M9z1Hb.png')]"
        date="2024-07-10"
        :listItems="[
          'Our Last Crusade or the Rise of a New World Season 2',
          'Love Is Indivisible by Twins',
        ]"
      />
      <AnimeDate
        backgroundImageClass="bg-[url('https://s4.anilist.co/file/anilistcdn/media/anime/cover/large/bx157371-K122OMMSKhXK.jpg')] bg-top"
        date="2024-07-12"
        :listItems="[
          'Bye Bye, Earth'
        ]"
      />
      <AnimeDate
        backgroundImageClass="bg-[url('https://s4.anilist.co/file/anilistcdn/media/anime/cover/large/bx154963-Ju6Ey3P5YHs2.jpg')]"
        date="2024-07-13"
        :listItems="[
          'Why Does Nobody Remember Me in This World?',
          'ATRI -My Dear Moments-',
          'Makeine: Too Many Losing Heroines!',
        ]"
      />
      <AnimeDate
        backgroundImageClass="bg-[url('https://s4.anilist.co/file/anilistcdn/media/anime/cover/large/bx162796-CFwUdsPSLpzv.jpg')] bg-bottom"
        date="2024-07-14"
        :listItems="[
          'Kinnikuman: Perfect Origin Arc',
          'Theatre of Darkness: Yamishibai 13',
        ]"
      />
      <AnimeDate
        backgroundImageClass="bg-[url('https://s4.anilist.co/file/anilistcdn/media/anime/cover/large/bx176660-4sDfmx2fOZRJ.jpg')] bg-bottom"
        date="2024-07-17"
        :listItems="[
          'Sengoku Youko: The Chaos of a Thousand Demons Arc',
        ]"
      />
      <AnimeDate
        backgroundImageClass="bg-[url('https://s4.anilist.co/file/anilistcdn/media/anime/cover/large/bx167991-uOu8ggPXzVUQ.jpg')] bg-bottom"
        date="2024-08-07"
        :listItems="[
          'Delico\'s Nursery',
        ]"
      />
      <AnimeDate
        backgroundImageClass="bg-[url('assets/empty.png')]"
        date=""
        :listItems="[]"
      />
      <AnimeDate
        backgroundImageClass="bg-[url('assets/empty.png')]"
        date=""
        :listItems="[]"
      />
    </div>
    <p><sup>1</sup> Each episode will stream four days in advance of the TV broadcast starting on July 3, 2024, on ABEMA. Regular broadcasting begins on July 7, 2024.</p>

    <footer class="flex justify-between mt-8 items-center text-gray-400">
      <p>Source: LiveChart.me Summer 2024 - All airing dates are expressed in BST. 27/06/2024 06:00 (BST)</p>
      <div>
        <div class="flex items-center">Created by<div class="bg-[url('assets/pfp.png')] bg-cover w-8 h-8 mx-1 rounded-md"></div>enonibobble, inspired by u/AnimeSamaDesu.</div>
      </div>
    </footer>
  </div>
</template>
