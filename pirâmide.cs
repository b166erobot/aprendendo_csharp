using System;


namespace Teste
{
  class Programa
  {
    static void ImprimirPirâmide(int n)
    {
      for (int i = 1; i <= n; i++)
      {
        for (int j = i; j <= n; j++)
        {
          Console.Write(" ");
        }
        for (int k = 1; k <= 2 * i - 1; k++)
        {
          Console.Write("*");
        }
        Console.WriteLine();
      }
    }

    static void Main()
    {
      ImprimirPirâmide(10);
    }
  }
}
