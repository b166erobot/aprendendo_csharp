using System;


namespace Teste
{
  class Programa
  {
    static void Main()
    {
      do
      {
        Console.Write("deseja somar? (sim/não): ");
        string continuar = Console.ReadLine();
        if (continuar == "sim")
        {
          Console.Write("x = ");
          int x = Convert.ToInt32(Console.ReadLine());

          Console.Write("y = ");
          int y = Convert.ToInt32(Console.ReadLine());

          int soma = x + y;
          Console.WriteLine("O resultado é igual a {0}", soma);
        }
        else
          break;
      }
      while(true);
    }
  }
}
