public static class TurmasRepository{
  public static List<Turmas> Turmas {get;set;} = Turmas = new List<Turmas>();

  public static void Add(Turmas turma){    
    Turmas.Add(turma);
  }  

  public static Turmas GetBy(int id){
    return Turmas.FirstOrDefault( p => p.Id == id );
  }

  public static void Remove(Turmas turma){
    Turmas.Remove(turma);
  }
}