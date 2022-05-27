<template>
  <v-app>
    <v-main>
      <v-container class="fill-height" fill-height fluid>
        <v-row align="center"
            justify="center" class="fill-height mt-n10">
            <v-col>
              <Calculator />
            </v-col>
        </v-row>
      </v-container>
    </v-main>
  </v-app>
</template>
<script setup>
import { ref } from 'vue'
import Calculator from './components/Calculator.vue'
</script>
<style scoped>
.v-main{
    background:#8a7a7a2b;
}
</style>
