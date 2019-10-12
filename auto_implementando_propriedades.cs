using System;


namespace SoloLearn
{
  class Pessoa
  {
    private string nome;
    public string Nome { get; set; }
  }

  class Programa
  {
    static void Main()
    {
      Pessoa bob = new Pessoa();
      bob.Nome = "Bob";
      Console.WriteLine(bob.Nome);
    }
  }
}
