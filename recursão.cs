using System;
// hell yeah! isso é uma coisa que eu domino bem!


namespace Teste
{
  class Programa
  {
    static int Fatorial(int número)
    {
      if (número == 1)
        return 1;
      return número * Fatorial(número - 1);
    }

    static void Main()
    {
      Console.WriteLine("o fatorial de 5 é {0}", Fatorial(5));
    }
  }
}
