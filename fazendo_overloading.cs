using System;


namespace Teste
{
  class Programa
  {
    static void imprimir(int a)
    {
      Console.WriteLine("valor: " + a);
    }

    static void imprimir(double a)
    {
      Console.WriteLine("valor: " + a);
    }

    static void imprimir(string rótulo, double a)
    {
      Console.WriteLine(rótulo + a);
    }

    static void Main()
    {
      imprimir(11);
      imprimir(3.2);
      imprimir("teste: ", 4.4);
    }
  }
}
