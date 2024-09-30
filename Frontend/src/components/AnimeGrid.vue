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
      :split-at="item.SplitAt === undefined ? splitAt : item.SplitAt"
      :list-items="item.Entries"
    />
  </div>
</template>

<script lang="ts">
import schedule from "../schedule.json";
import emptyPng from "../assets/empty.png";
const splitAt = 4;

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
        const span = item.Entries.length > splitAt ? 2 : 1; // Determine if it spans 1 or 2 columns

        // If adding this item exceeds the row, fill the row with empty spaces
        if (rowColumns + span > 6) {
          for (let i = rowColumns; i < 6; i++) {
            result.push(empty); // Empty space filler
          }
          rowColumns = 0; // Reset column count for the new row
        }

        result.push(item);
        rowColumns += span;
      }

      // If there are any remaining columns in the last row, fill them with empty spaces
      for (let i = rowColumns; i < 6; i++) {
        result.push(empty);
      }

      return result;
    },
  },
};
</script>
