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
  return Results.Created($"/products /{turma.Codigo}", turma.Codigo);
});
app.MapGet("/turmas/{id}", ([FromRoute] int id ) =>{
  var turma = TurmasRepository.GetBy(id);
  if(turma != null){
    return Results.Ok(turma);
  }
  return Results.NotFound();
});
app.MapPut("/turmas", (Turmas turma) =>{
  var TurmaSaved = TurmasRepository.GetBy(turma.Id);
  TurmaSaved.DescricaoTurma = turma.DescricaoTurma;
  TurmaSaved.DtInicial = turma.DtInicial;
  TurmaSaved.DtFinal = turma.DtFinal;
  TurmaSaved.Codigo = turma.Codigo;
  return Results.Ok();
});
app.MapDelete("/turmas/{id}", ([FromRoute] int id) => {
  var TurmaDelete = TurmasRepository.GetBy(id);
  TurmasRepository.Remove(TurmaDelete);
  return Results.Ok();
});

//alunos
app.MapPost("/alunos", (Alunos aluno) => {
    AlunosRepository.Add(aluno);
    return Results.Ok();
});
app.MapGet("/alunos/{id}", ([FromRoute] int id ) => {
    var aluno = AlunosRepository.GetBy(id);
    if(aluno != null){
      return Results.Ok(aluno);
    }
    return Results.NotFound();
});
app.MapPut("/alunos", (Alunos aluno) => {
  var alunoSaved = AlunosRepository.GetBy(aluno.Id);
  alunoSaved.Nome = aluno.Nome;
  alunoSaved.Cpf = aluno.Cpf;
  return Results.Ok();
});

//atividades
app.MapPost("/atividades", (Atividades atividade) => {
  AtividadesRepository.Add(atividade);
  return Results.Ok();
});

app.MapGet("/atividades/{id}", ([FromRoute] int id) => {
  var atividade = AtividadesRepository.GetBy(id);
  if(atividade != null){
    return Results.Ok(atividade);
  }
  return Results.NotFound();
});
app.MapPut("/atividades", (Atividades atividade) => {
  var AtivSaved = AtividadesRepository.GetBy(atividade.Id);
  AtivSaved.Codigo = atividade.Codigo;
  AtivSaved.Descricao = atividade.Descricao;
  AtivSaved.DtLimite = atividade.DtLimite;
  
  return Results.Ok();
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
