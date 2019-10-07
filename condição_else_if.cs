using System;


namespace Teste
{
  class Programa
  {
    static void Main()
    {
      int x = 33;
      Console.Write("o valor de x é ");
      if (x == 8)
      Console.Write("8\n");
      else if (x == 18)
      Console.Write("18\n");
      else if (x == 33)
      Console.Write("33\n");
      else
      {
        Console.Write("{0}\n", x);
        Console.WriteLine(
          "não passou por nenhuma das condições acima. somente o else"
        );  
      }
    }
  }
}
