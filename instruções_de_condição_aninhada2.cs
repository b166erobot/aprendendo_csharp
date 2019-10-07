using System;


namespace Teste
{
  class Programa
  {
    static void Main()
    {
      int idade = 17;
      if (idade > 14)
      {
        if (idade > 18)
        Console.WriteLine("Adulto");
        else
        Console.WriteLine("adolecente");
      }
      else
      {
        if (idade > 0)
        Console.WriteLine("criança");
        else
        Console.WriteLine("alguma coisa está errada.");
      }
    }
  }
}
// resposta esperada: adolecente
