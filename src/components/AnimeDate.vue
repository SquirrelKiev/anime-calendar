<script setup lang="ts">
</script>

<template>
  <div :class="containerWidthClass" class="m-4">
    <div
      :class="backgroundImageClass"
      class="bg-cover bg-center h-48 flex flex-col relative rounded overflow-hidden"
    >
      <div class="mt-auto mb-2 ml-1 text-stroke z-20">
        <p class="font-bold stroke-black text-base text-cyan-400 -mb-1">
          {{ calculatedDay }}
        </p>
        <p class="text-3xl font-bold">{{ formattedDate }}</p>
      </div>
      <div
        class="from-transparent from-30% to-black bg-gradient-to-b w-full h-full absolute"
      ></div>
    </div>
    <div class="flex mt-2">
      <ul class="list-disc font-inter font-medium" :class="{'w-1/2': secondList.length > 0}">
        <li class="marker:text-cyan-400" v-for="(item, index) in firstList" :key="index" v-html="item"></li>
      </ul>
      <ul v-if="secondList.length > 0" class="list-disc font-inter font-medium w-1/2">
        <li class="ml-6 marker:text-cyan-400" v-for="(item, index) in secondList" :key="index" v-html="item"></li>
      </ul>
    </div>
  </div>
</template>

<script lang="ts">
export default {
  props: {
    backgroundImageClass: {
      type: String,
      required: true,
    },
    date: {
      type: String,
      required: true,
    },
    listItems: {
      type: Array,
      required: true,
    },
    splitAt: {
      type: Number,
      default: 4,
    }
  },
  computed: {
    calculatedDay() {
      if (this.date === "") {
        return "";
      }
      let parsedDate: Date = new Date(this.date);
      const options: Intl.DateTimeFormatOptions = { weekday: "long" };
      return new Intl.DateTimeFormat("en-US", options).format(parsedDate);
    },
    formattedDate() {
      if (this.date === "") {
        return "";
      }
      let parsedDate: Date = new Date(this.date);
      const options: Intl.DateTimeFormatOptions = { month: "short", day: "numeric" };
      let formatted: string = new Intl.DateTimeFormat("en-US", options).format(parsedDate);
      return formatted.toUpperCase().replace(" ", " ");
    },
    containerWidthClass() {
      return this.listItems.length > this.splitAt ? "w-[26rem]" : "w-48";
    },
    firstList() {
      return this.listItems.slice(0, this.splitAt);
    },
    secondList() {
      return this.listItems.slice(this.splitAt);
    },
  },
};
</script>
