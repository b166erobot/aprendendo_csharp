using System;


namespace SoloLearn
{
  class Pessoa
  {
    private string nome;  // field

    public string Nome  // property
    {
      get { return nome; }
      set { nome = value; }
      // value é uma variável fixa que retorna o valor passado para a property.
    }
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
