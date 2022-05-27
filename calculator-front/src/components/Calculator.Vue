<template>
       <v-card
    :loading="loading"
    class="mx-auto my-12"
    width="450"
  >
    <v-card-text align="center" style="padding:40px !important">
      <div class="mb-5 text-h2 text-center" style="font-size:4.7rem !important">Calculator</div>
      <div class="mb-10 text-h6 font-weight-light">Please use comma separated</div>
      <v-form ref="form">
        <v-text-field
          v-model="inputs"
          label="Enter Number"
          color="purple darken-2"
          class="mb-3"
          hide-details=""
        ></v-text-field>
        <v-select
          v-model="select"
          :items="items"
          label="Operation"
          class="mb-3"
          hide-details=""
          required
        ></v-select>
         <v-text-field
          v-model="output"
          label="Output"
          color="purple darken-2"
          class="mb-3"
          hide-details=""
          filled
        ></v-text-field>
        <v-card-text>
            <v-alert
            v-show="hasError"
            type="error"
            outlined
            >
            {{ errorMsg }}
            </v-alert>
        </v-card-text>
        <v-btn
        color="primary"
        @click="calculate"
      >
        Calculate 
      </v-btn>
      </v-form>
    </v-card-text>
  </v-card>
</template>

<script setup>
import { ref } from 'vue'

const API_URL = 'https://localhost:5001'
const output = ref('');
const inputs = ref('');
const select = ref('Add');
const hasError = ref(false);
const errorMsg = ref('The API is down');

async function calculate(){
    if (inputs.value == ''){
        errorMsg.value = 'Please fill in the input first';
        hasError.value = true;
        return;
    }
    try{
        var result = await fetch(`${API_URL}/${select.value}?${inputs.value.split(',').map(i => `inputs=${i}`).join('&')}`)
        var resp = await result.json();
        if (resp.errors){
            output.value = ''
            hasError.value = true
            errorMsg.value = JSON.stringify(resp.errors)
        }else{
            output.value = resp;
            hasError.value = false;
        }
    }catch (err){
        errorMsg.value = 'There seems to be issue with the API';
        hasError.value = true;
    }
}
</script>
<script>
export default {
  name: 'Calculator',
  data: () => ({
    items: [
      'Add',
      'Substract',
      'Multiply',
      'Divide',
      'SplitEq',
      'SplitNum',
    ]
  }),
}
</script>

<style scoped>
.v-btn{
    background:#604ecf !important;
    width: 100%;
    padding: 30px;
    border-radius: 10px;
}
</style>