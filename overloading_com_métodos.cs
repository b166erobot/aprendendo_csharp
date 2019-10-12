using System;


namespace Teste
{
  class Programa
  {
    static void imprimir(int x)
    {
      Console.WriteLine("Valor: " + x);
    }

    static void imprimir(double x)
    {
      Console.WriteLine("Valor: " + x);
    }

    static void Main()
    {
      imprimir(3);
    }
  }
}
