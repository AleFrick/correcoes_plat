public static class AlunosRepository{
  public static List<Alunos> Alunos {get;set;} = Alunos = new List<Alunos>();

  public static void Add(Alunos aluno){
    if(Alunos == null)
      Alunos = new List<Alunos>();
    Alunos.Add(aluno);
  }  

  public static Alunos GetBy(int id){
    return Alunos.FirstOrDefault( p => p.Id == id );
  }
}