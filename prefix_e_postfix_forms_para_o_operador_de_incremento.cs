using System;


namespace Teste
{
  class Programa
  {
    static void Main()
    {
      Console.WriteLine(
        "O prefix incrementa o valor da variável e então continua com" +
        " a expressão.\nint x = 3;\nint y = ++x;"
      );
      int x = 3;
      int y = ++x;
      Console.WriteLine("x == {0}, y == {1}", x, y);
      Console.WriteLine(
        "\n\nO postfix executa a espressão e depois incrementa.\nx = 3;" +
        "\ny = ++x;"
      );
      x = 3;
      y = x++;
      Console.WriteLine("x == {0}, y == {1}", x, y);
    }
  }
}
