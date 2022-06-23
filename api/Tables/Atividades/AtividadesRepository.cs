public static class AtividadesRepository
{
    public static List<Atividades> Atividades { get; set; } = Atividades = new List<Atividades>();

    public static void Add(Atividades atividade)
    {
        if (Atividades == null)
            Atividades = new List<Atividades>();
        Atividades.Add(atividade);
    }

    public static Atividades GetBy(int id)
    {
        return Atividades.FirstOrDefault(p => p.Id == id);
    }
}