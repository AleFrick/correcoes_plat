using System;
using System.Web;
using System.ComponentModel.DataAnnotations;

public class Turmas{
  public int Id {get;set;}
  public string Codigo {get;set;}
  [DataType(DataType.Date)]  
  public DateTime DtInicial {get;set;}  
  [DataType(DataType.Date)]
  public DateTime? DtFinal {get;set;}
  public string DescricaoTurma {get;set;} 
}