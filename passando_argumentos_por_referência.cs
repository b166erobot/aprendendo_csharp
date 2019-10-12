using System;


namespace Teste
{
  class Programa
  {
    // método que altera uma variável fora do seu escopo.
    static void pow2(ref int y)
    {
      y = y * y;
    }

    static void Main()
    {
      int x = 3;
      pow2(ref x);
      Console.WriteLine(
        "o valor da variável x precisa ser diferente de 3: x = {0}", x
      );
    }
  }
}
