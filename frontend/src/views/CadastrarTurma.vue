<template>
  <v-form>
    <v-container>
      <v-row>
        <v-col cols="12" md="8" >
          <v-text-field
            v-model="sDescrTurma"            
            label="Turma"
            required
            append-icon="mdi-magnify" 
          ></v-text-field>
        </v-col>

        <v-col cols="12" md="4" >
          <v-checkbox
            v-model="bTurmaAtiva"
            :label="`Turma Ativa`"
          ></v-checkbox>
        </v-col>
      </v-row>
      <v-row>
        <v-col cols="12" lg="6" >
          <v-menu
            v-model="bDtInicial"
            :close-on-content-click="false"
            max-width="290"
          >
            <template v-slot:activator="{ on, attrs }">
              <v-text-field
                :value="computedDataInicial"
                clearable
                label="Data Inicial das Aulas"
                readonly
                v-bind="attrs"
                v-on="on"
                @click:clear="dDtInicial = null"
              ></v-text-field>
            </template>
            <v-date-picker
              v-model="dDtInicial"
              @change="bDtInicial = false"
            ></v-date-picker>
          </v-menu>
        </v-col>
        <v-col cols="12" lg="6" >
          <v-menu
            v-model="bDtFinal"
            :close-on-content-click="false"
            max-width="290"
          >
            <template v-slot:activator="{ on, attrs }">
              <v-text-field
                :value="computedDataFinal"
                clearable
                label="Data Final das Aulas"
                readonly
                v-bind="attrs"
                v-on="on"
                @click:clear="dDtFinal = null"
              ></v-text-field>
            </template>
            <v-date-picker
              v-model="dDtFinal"
              @change="bDtFinal = false"
            ></v-date-picker>
          </v-menu>
        </v-col>
      </v-row>
      <v-card>        
        <v-container>
          <v-card-title>Dias da Semanda </v-card-title>
          <v-row>        
            <v-col cols="12" sm="4" md="2">
              <v-checkbox value='aDiaSemana.bSegunda' label='Segunda-feira'></v-checkbox>
            </v-col>
            <v-col cols="12" sm="4" md="2">
              <v-checkbox value='aDiaSemana.bTerca' label='Terca-feira'></v-checkbox>
            </v-col>
            <v-col cols="12" sm="4" md="2">
              <v-checkbox value='aDiaSemana.bQuarta' label='Quarta-feira'></v-checkbox>
            </v-col>        
          
            <v-col cols="12" sm="4" md="2">
              <v-checkbox value='aDiaSemana.bQuinta' label='Quinta-feira'></v-checkbox>
            </v-col>
            <v-col cols="12" sm="4" md="2">
              <v-checkbox value='aDiaSemana.bSexta' label='Sexta-feira'></v-checkbox>
            </v-col>                
            <v-col cols="12" sm="4" md="2">
              <v-checkbox value='aDiaSemana.bSabado' label='Sabado-feira'></v-checkbox>
            </v-col>         
            <v-col cols="12" sm="4" md="2">
              <v-checkbox value='aDiaSemana.bDomingo' label='Domingo-feira'></v-checkbox> 
            </v-col>
          </v-row>
        </v-container>
      </v-card>
    </v-container>                                      
    <ButtonSaveCancel />
  </v-form>
</template>
<script>
  import moment from 'moment'
  import { format, parseISO } from 'date-fns' 
  import ButtonSaveCancel from '../components/ButtonSaveCancel.vue' 
  export default {
    data: () => ({
      // https://github.com/date-fns/date-fns/blob/master/docs/upgradeGuide.md#string-arguments
      dDtInicial: format(parseISO(new Date().toISOString()), 'yyyy-MM-dd'),
      dDtFinal: format(parseISO(new Date().toISOString()), 'yyyy-MM-dd'),
      aDiaSemana: {
        bSegunda: false,
        bTerca: false,
        bQuarta: false,
        bQuinta: false,
        bSexta: false,
        bSabado: false,
        bDomingo: false,
      },
      bDtInicial: false,   
      bDtFinal: false,
      sDescrTurma: '',
      bTurmaAtiva: false 
    }),
    components:{
      ButtonSaveCancel
    },
    computed: {
      computedDataInicial () {
        moment.locale('pt-br');        
        return this.dDtInicial ? moment(this.dDtInicial).format('L') : ''
      },
      computedDataFinal () {
        moment.locale('pt-br');        
        return this.dDtFinal ? moment(this.dDtFinal).format('L') : ''
      },
    },
    methods: {
      buscarTurma(){
        alert('Buscar Turma')
      }
    }
  }
      
</script>
