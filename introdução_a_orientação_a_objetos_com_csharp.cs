using System;


namespace SoloLearn
{
  class Programa
  {
    class Pessoa
    {
      // int idade;
      // string nome;

      public void Dizer(string texto)
      {
        Console.WriteLine(texto);
      }
    }

    static void Main()
    {
      Pessoa qualquer = new Pessoa();
      // Console.WriteLine(qualquer.nome);
      // Console.WriteLine(qualquer.idade);
      qualquer.Dizer("estou instânciado e funcionando!");
    }
  }
}
