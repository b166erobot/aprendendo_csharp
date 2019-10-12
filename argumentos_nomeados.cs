using System;


namespace Teste
{
  class Programa
  {
    static int Area(int x, int y)
    {
      return x * y;
    }

    static void Main()
    {
      int resposta = Area(y: 3, x: 2);
      Console.WriteLine(resposta);
    }
  }
}
