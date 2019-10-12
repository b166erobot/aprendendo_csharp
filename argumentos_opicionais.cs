using System;


namespace Teste
{
  class Programa
  {
    static string join(string x = "exemplo de ",
                       string y = "argumento opcional")
    {
      return x + y;
    }

    static void Main()
    {
      Console.WriteLine(join());
      Console.WriteLine(join("concatenando ", "strings"));
    }
  }
}
