using System;


namespace SoloLearn
{
  class Pessoa
  {
    private int idade = 0;

    public int Idade
    {
      get { return idade; }
      set
      {
        if (value > 0)
          idade = value;
        else
          Console.WriteLine(
            "a idade precisa ser maior que 0. valor passado {0}", value
          );
      }
    }
  }

  class Programa
  {
    static void Main()
    {
      Pessoa bob = new Pessoa();
      bob.Idade = -2;
      bob.Idade = 18;
      Console.WriteLine(bob.Idade);
    }
  }
}
