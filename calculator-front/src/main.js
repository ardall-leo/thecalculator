import { createApp } from 'vue'
import App from './App.vue'
import 'vuetify/styles'
import { createVuetify } from 'vuetify'
import { loadFonts } from './plugins/webfontloader'
import * as components from 'vuetify/components'
import * as directives from 'vuetify/directives'

loadFonts()

const vuetify = createVuetify({
  components,
  directives,
})

const app = createApp(App)
app.use(vuetify)

app.mount('#app')