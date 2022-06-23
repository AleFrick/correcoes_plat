<template>
  <v-form v-model="valid">
    <v-container>
      <v-row>
        <v-col cols="12" md="8" >
          <v-text-field
            v-model="firstname"
            :rules="nameRules"
            :counter="10"
            label="Nome Completo"
            required
          ></v-text-field>
        </v-col>
        <v-col cols="12" md="4">
          <v-text-field
            v-model="email"
            :rules="emailRules"
            label="E-mail"
            required
          ></v-text-field>
        </v-col>
      </v-row>
      <v-row>
        <v-col cols="12" >
          <v-text-field
            v-model="firstname"
            :rules="nameRules"            
            label="Turma"
            required
            append-icon="mdi-magnify" 
            @click:append="buscarTurma"           
          >         
          </v-text-field>
          
        </v-col>
      </v-row>
      
    </v-container>
    <ButtonSaveCancel />
  </v-form>
</template>

<script>
  import ButtonSaveCancel from '../components/ButtonSaveCancel.vue' 
  export default {
    name: 'CadastrarAluno',

    components:{
      ButtonSaveCancel
    },
    methods: {
      buscarTurma(){
        alert('Buscar Turma')
      }
    }
  }
</script>
