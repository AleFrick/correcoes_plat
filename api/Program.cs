using SampleNamespace;
using System.Web;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
const string msgInsertOk = "Dados inseridos com sucesso.";
const string msgUpdateOk = "Dados atualiados com sucesso.";
const string msgDeleteOk = "Dados removidos com sucesso.";
//turmas
app.MapPost("/turmas", (Turmas turma) =>{
  TurmasRepository.Add(turma);  
  return msgInsertOk;  
});
app.MapGet("/turmas/{id}", ([FromRoute] int id ) =>{
  var turma = TurmasRepository.GetBy(id);
  return turma;
});
app.MapPut("/turmas", (Turmas turma) =>{
  var TurmaSaved = TurmasRepository.GetBy(turma.Id);
  TurmaSaved.DescricaoTurma = turma.DescricaoTurma;
  TurmaSaved.DtInicial = turma.DtInicial;
  TurmaSaved.DtFinal = turma.DtFinal;
  TurmaSaved.Codigo = turma.Codigo;
  return msgUpdateOk;
});
app.MapDelete("/turmas", ([FromRoute] int id) => {
  var TurmaDelete = TurmasRepository.GetBy(id);
  TurmasRepository.Remove(TurmaDelete);
  return msgDeleteOk;
});

//alunos
app.MapPost("/alunos", (Alunos aluno) => {
    AlunosRepository.Add(aluno);
    return msgInsertOk;
});
app.MapGet("/alunos/{id}", ([FromRoute] int id ) => {
    var aluno = AlunosRepository.GetBy(id);
    return aluno;
});
app.MapPut("/alunos", (Alunos aluno) => {
  var alunoSaved = AlunosRepository.GetBy(aluno.Id);
  alunoSaved.Nome = aluno.Nome;
  alunoSaved.Cpf = aluno.Cpf;
  return msgUpdateOk;
});

//atividades
app.MapPost("/atividades", (Atividades atividade) => {
  AtividadesRepository.Add(atividade);
  return msgInsertOk;
});
app.MapGet("/atividades/{id}", ([FromRoute] int id) => {
  var atividade = AtividadesRepository.GetBy(id);
});
app.MapPut("/atividades", (Atividades atividade) => {
  var AtivSaved = AtividadesRepository.GetBy(atividade.Id);
  AtivSaved.Codigo = atividade.Codigo;
  AtivSaved.Descricao = atividade.Descricao;
  AtivSaved.DtLimite = atividade.DtLimite;
  
  return msgUpdateOk;
});

//textos
app.MapPost("/textos", () => {
  return "Cadastrar Textos";
});
app.MapPut("/textos", () => {
  return "Atualizar Textoss";
});
app.MapDelete("/textos", () => {
  return "Deletar Textoss";
});

app.Run();
