public static class AlunosRepository{
  public static List<Alunos> Alunos {get;set;} = Alunos = new List<Alunos>();

  public static void Init(IConfiguration configuration){
    var alunos = configuration.GetSection("Alunos").Get<List<Alunos>>();
    Alunos = alunos;
  }

  public static void Add(Alunos aluno){    
    Alunos.Add(aluno);
  }  

  public static Alunos GetBy(int id){
    return Alunos.FirstOrDefault( p => p.Id == id );
  }
}