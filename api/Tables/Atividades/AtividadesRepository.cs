public static class AtividadesRepository
{
    public static List<Atividades> Atividades { get; set; } = Atividades = new List<Atividades>();

    public static void Add(Atividades atividade){        
        Atividades.Add(atividade);
    }

    public static Atividades GetBy(int id)
    {
        return Atividades.FirstOrDefault(p => p.Id == id);
    }
}