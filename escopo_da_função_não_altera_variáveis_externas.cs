using System;


namespace Teste
{
  class Programa
  {
    static void pow2(int x)
    {
      x *= x;
    }

    static void Main()
    {
      int x = 3;
      pow2(x);
      Console.WriteLine(x);
      Console.WriteLine("o escopo da função não altera a variável externa.");
      Console.WriteLine("portanto o resultado acima precisa ser igual a 3");
    }
  }
}
