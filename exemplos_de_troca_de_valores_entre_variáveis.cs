using System;


namespace Teste
{
  class Programa
  {
    static void swap(ref int x, ref int y)
    {
      int temp = x;
      x = y;
      y = temp;
    }

    static void Main()
    {
      int x = 2;
      int y = 3;
      Console.WriteLine("trocando valores entra variáveis em csharp:");
      Console.WriteLine("x = {0}, y = {1}", x, y);
      swap(ref x, ref y);
      Console.WriteLine(
        "por referência, método não puro: x = {0}, y = {1}", x, y
      );
    }
  }
}
