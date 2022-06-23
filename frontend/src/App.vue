<template>
  <v-app> 
    <v-navigation-drawer
      v-model="drawer"
      absolute
      temporary
      app
    >
      <v-list
        nav
        dense
      >
        <v-list-item-group
          v-model="group"
          active-class="deep-purple--text text--accent-4"
        >
          <v-list-item>
            <v-list-item-icon>
              <v-icon>mdi-home</v-icon>
            </v-list-item-icon>
            <v-list-item-title v-on:click="openPage(`/`)">Home</v-list-item-title>
          </v-list-item>

          <v-list-item>
            <v-list-item-icon>
              <v-icon>mdi-account</v-icon>
            </v-list-item-icon>
            <v-list-item-title v-on:click="openPage(`/cadastrar/aluno`)">Alunos</v-list-item-title>
          </v-list-item>

          <v-list-item>
            <v-list-item-icon>
              <v-icon>mdi-account-group</v-icon>
            </v-list-item-icon>
            <v-list-item-title v-on:click="openPage('/cadastrar/turma')">Turmas</v-list-item-title>
          </v-list-item>

          <v-list-item>
            <v-list-item-icon>
                <v-icon>mdi-book-open-variant</v-icon>
            </v-list-item-icon>
            <v-list-item-title v-on:click="openPage('/cadastrar/texto')">Textos</v-list-item-title>            
          </v-list-item>

          <v-list-item>
            <v-list-item-icon>
                <v-icon>mdi-book-open-page-variant </v-icon>
            </v-list-item-icon>
            <v-list-item-title v-on:click="openPage('/cadastrar/atividade')">Atividades</v-list-item-title>            
          </v-list-item>
        </v-list-item-group>
      </v-list>
    </v-navigation-drawer>

    <v-app-bar
      absolute
      color="#6A76AB"
      dark
      app
    >
      <v-app-bar-nav-icon @click="drawer = true"></v-app-bar-nav-icon>
      <v-toolbar-title>Correções</v-toolbar-title>
    </v-app-bar>
    <v-main>
      <v-container>
        <router-view/>
      </v-container>
    </v-main>
  </v-app>
</template>

<script>

export default {
  name: 'App',
    data: () => ({
      drawer: false,
      group: null,
    }),
  methods: {
    openPage(psRoute){      
      this.$router.push(psRoute)            
    },    
  }
};
</script>
