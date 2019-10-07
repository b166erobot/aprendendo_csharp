using System;


namespace Teste
{
  class Programa
  {
    static void Main()
    {
      int numero = 0;
      while (numero < 20)
      {
        if (numero == 5)
          break;
        Console.WriteLine(numero);
        numero++;
      }
    }
  }
}
