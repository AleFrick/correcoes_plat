namespace SampleNamespace
{
  class Pessoa
  {
    public string Nome {get;set;}
    private string sobrenome;
    public string WhoAmI()
    {
      sobrenome = "casemiro";
      return Nome + " " + sobrenome;
    }
  }
}