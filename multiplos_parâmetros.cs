using System;


namespace Teste
{
  class Programa
  {
    static int Soma(int x, int y)
    {
      return x + y;
    }

    static void Main()
    {
      int valor1 = 2;
      int valor2 = 4;
      int resultado = Soma(valor1, valor2);
      Console.WriteLine(
        "a soma de {0} com {1} é {2}", valor1, valor2, resultado
      );
    }
  }
}
