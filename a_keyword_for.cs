using System;


namespace Teste
{
  class Programa
  {
    static void Main()
    {
      for (int x = 10; x < 15; x++)
      {
        Console.WriteLine("valor de x é: {0}", x);
      }
      Console.WriteLine(
        "\nComo o for funciona no C-Sharp:\n" +
        "for (inicio; condição; incremento)\n" +
        "{\n  // corpo do for.\n  declaração(variável)\n}\n"
      );
    }
  }
}
