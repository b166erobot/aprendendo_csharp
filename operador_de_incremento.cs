using System;


namespace Teste
{
  class Programa
  {
    static void Main()
    {
      int x = 10;
      x++;
      Console.WriteLine(
        "O operador '++' na frente de uma variável é a mesma coisa que x += 1;"
      );
      Console.WriteLine("int x = 10;\nx++;\nConsole.WriteLine(x);");
      Console.WriteLine(x);
    }
  }
}
