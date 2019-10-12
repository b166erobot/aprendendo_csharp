using System;


namespace Teste
{
  class Programa
  {
    // método SquareRoot
    static double SquareRoot(int x)
    {
      return Math.Pow(x, 0.5);
    }

    static void Main()
    {
      // Usando o método SquareRoot da classe Programa
      int x = 25;
      double raiz = SquareRoot(x);  // 5
      Console.WriteLine("a raiz quadrada de {0} é {1}", x, raiz);
    }
  }
}
