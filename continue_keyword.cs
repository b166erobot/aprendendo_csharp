using System;


namespace Teste
{
  class Programa
  {
    static void Main()
    {
      for (int i = 0; i < 10; i++)
      {
        if (i == 5)
        {
          Console.WriteLine(
            "o número desta linha não será imprimido. desculpe"
          );
          continue;
        }
        Console.WriteLine(i);
      }
    }
  }
}
