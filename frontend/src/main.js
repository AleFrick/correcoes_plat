import Vue from 'vue'
import App from './App.vue'
import router from './router'
import vuetify from './plugins/vuetify'
import 'vuetify/dist/vuetify.min.css'
import DatetimePicker from 'vuetify-datetime-picker'

Vue.use(DatetimePicker)

new Vue({
  router,
  vuetify,
  render: h => h(App)
}).$mount('#app')
