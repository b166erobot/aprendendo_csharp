using System;


namespace Teste
{
  class Programa
  {
    static void Main()
    {
      int x = 42;
      x += 2; // equivalente a: x = x + 2;
      x -= 6; // equivalente a: x = x - 6;
      x *= 2; // equivalente a: x = x * 2;
      x /= 2; // equivalente a: x = x / 2;
      x %= 3; // equivalente a: x = x % 3;
      Console.WriteLine(
        "imprimindo a resposta da conta aritimética acima: {0}", x
      );
    }
  }
}
