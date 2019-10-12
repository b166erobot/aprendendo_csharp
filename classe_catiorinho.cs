using System;


namespace SoloLearn
{
  class Programa
  {
    class Catiorinho
    {
      public string nome;
      public int idade;

      // public static void latir()
      // {
      //   Console.WriteLine("laika latindo: woof :)");
      // }
    }

    static void Main()
    {
      Catiorinho laika = new Catiorinho();
      laika.nome = "Laika";
      laika.idade = 10;
      Console.WriteLine(laika.nome);
      // laika.latir();
    }
  }
}
