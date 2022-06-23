import Vue from 'vue'
import VueRouter from 'vue-router'
import Home from '../views/Home.vue'
import CadastrarAluno from '../views/CadastrarAluno.vue'
import CadastrarTurma from '../views/CadastrarTurma.vue'
import CadastrarTexto from '../views/CadastrarTexto.vue'
import CadastrarAtividades from '../views/CadastrarAtividades.vue'
import PageNotFound from '../views/PageNotFound.vue'

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'Home',
    component: Home
  },
  {
    path: '/cadastrar/aluno',
    name: 'CadastrarAluno',
    component: CadastrarAluno  
  },
  {
    path: '/cadastrar/turma',
    name: 'CadastrarTurma',
    component: CadastrarTurma
  },
  {
    path: '/cadastrar/texto',
    name: 'CadastrarTexto',
    component: CadastrarTexto
  },
  {
    path: '/cadastrar/atividade',
    name: 'CadastrarAtividades',
    component: CadastrarAtividades
  },{
    path: "*", 
    component: PageNotFound 
  }
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router
