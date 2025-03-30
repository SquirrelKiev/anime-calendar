<script setup lang="ts">
import AnimeDate from "./AnimeDate.vue";
</script>

<template>
  <div class="grid grid-cols-6 gap-8 my-4">
    <AnimeDate
      v-for="item in entriesWithSpaces"
      :background-image="item.BannerUrl"
      :background-position="item.BannerPosition"
      :date="item.StartDate"
      :split-at="item.SplitAt === undefined ? Math.max(item.Entries.length / 2, 4) : item.SplitAt"
      :list-items="item.Entries"
    />
  </div>
</template>

<script lang="ts">
import schedule from "../schedule.json";
import emptyPng from "../assets/empty.png";

const columnsPerRow = 6;

export default {
  computed: {
    entriesWithSpaces() {
      let result: {
        StartDate: string;
        BannerUrl: string;
        BannerPosition: string;
        Entries: string[];
        SplitAt?: number;
      }[] = [];
      let rowColumns = 0;

      const empty = {
        StartDate: "",
        BannerUrl: emptyPng,
        BannerPosition: "center center",
        Entries: [],
      };

      for (const item of Object.values(schedule.Entries)) {
        const span = item.Entries.length > 4 ? 2 : 1;

        if (rowColumns + span > columnsPerRow) {
          for (let i = rowColumns; i < columnsPerRow; i++) {
            result.push(empty);
          }
          rowColumns = 0;
        }

        result.push(item);
        rowColumns += span;
      }

      for (let i = rowColumns; i < columnsPerRow; i++) {
        result.push(empty);
      }

      return result;
    },
    
  },
};
</script>
