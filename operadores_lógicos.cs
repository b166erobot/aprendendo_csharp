using System;


namespace Teste
{
  class Programa
  {
    static void Main()
    {
      if (true && true)
      {
        Console.WriteLine("&& funcionou");
      }
      if (false || true)
      {
        Console.WriteLine("|| funcionou");
      }
      if (!false)
      {
        Console.WriteLine("! funcionou");
      }
      Console.WriteLine(
        "\n\noperador - nome do operador - usagem\n" +
        "&& - and - variável && outra_variável\n" +
        "|| - or - variável || outra_variável\n" +
        "! - not - !variável"
      );
    }
  }
}
