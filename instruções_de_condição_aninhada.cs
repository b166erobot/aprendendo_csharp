using System;


namespace Teste
{
  class Programa
  {
    static void Main()
    {
      double nota = 100.0;
      if (nota >= 50)
      {
        Console.WriteLine("Você passou!");
        if (nota == 100)
        Console.WriteLine(
          "Meus parabéns! Poucos alunos conseguem tirar a nota máxima"
        );
      }
      else
      Console.WriteLine("Você não passou.");
    }
  }
}
