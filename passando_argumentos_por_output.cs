using System;


namespace Teste
{
  class Programa
  {
    static void DefinirValores(out int x, out int y)
    {
      x = 5;
      y = 42;
    }

    static void Main()
    {
      int a, b;
      DefinirValores(out a, out b);
      Console.WriteLine(
        "as variáveis 'a' e 'b' precisam ter valores definidos aqui abaixo."
      );
      Console.WriteLine("a = {0}, b = {1}", a, b);
    }
  }
}
