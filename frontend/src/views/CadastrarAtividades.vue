<template>
  <v-container fluid>
    <v-row>
      <v-col cols="12" md="12" >
        <v-text-field
          v-model="nome"          
          :counter="10"
          label="Nome"
          required
        ></v-text-field>
      </v-col>
    </v-row>
    <v-row>
      <v-col cols="12" lg="6" >
        <v-menu
          v-model="bDtLimite"
          :close-on-content-click="false"
          max-width="290"
        >
          <template v-slot:activator="{ on, attrs }">
            <v-text-field
              :value="computedDataLimite"
              clearable
              label="Data Final"
              readonly
              v-bind="attrs"
              v-on="on"
              @click:clear="dDtLimite = null"
            ></v-text-field>
          </template>
          <v-date-picker
            v-model="dDtLimite"
            @change="bDtLimite = false"
          ></v-date-picker>
        </v-menu>
      </v-col>
    </v-row>
    <v-row>
      <v-col cols="12" md="12" >
        <v-textarea
          name="input-7-1"
          label="Descrição"
          value=""
        ></v-textarea>
      </v-col>
    </v-row>    
    <ButonSaveCancel/>
  </v-container>  
</template>
<script>
import ButonSaveCancel from '../components/ButtonSaveCancel.vue'
import moment from 'moment'
import { format, parseISO } from 'date-fns' 
export default ({
  data: () => ({
    dDtlimite: format(parseISO(new Date().toISOString()), 'yyyy-MM-dd'),
    bDtLimite: false,
    nome: ''
  }),
  components:{
    ButonSaveCancel
  },
  computed:{
    computedDataLimite () {
        moment.locale('pt-br');                
        return this.dDtLimite ? moment(this.dDtLimite).format('L') : ''
      },
  },
  
})
</script>
