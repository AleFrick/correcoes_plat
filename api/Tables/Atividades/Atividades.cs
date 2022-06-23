using System;
using System.Web;
using System.ComponentModel.DataAnnotations;

public class Atividades
{
    public int Id { get; set; }
    public string Descricao { get; set; }
    [DataType(DataType.Date)]
    public DateTime DtLimite { get; set; }
    public string Nome { get; set; }
    public string Codigo { get; set; }
}