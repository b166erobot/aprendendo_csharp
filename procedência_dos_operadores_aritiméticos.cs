using System;


namespace Teste
{
  class Programa
  {
    static void Main()
    {
      Console.WriteLine(
        "o '*' e o '/' tem uma alta procedência e portanto serão executados " +
        "primeiro.\nno exemplo abaixo podemos ver que 4 + 3 * 2 será igual à " +
        "10 pois a multiplicação ocorre primeiro que a soma."
      );
      int x = 4 + 3 * 2;
      Console.WriteLine("\nint x = 4 + 3 * 2;");
      Console.WriteLine("Console.WriteLine(x);");
      Console.WriteLine(x);
      Console.WriteLine(
        "\n\nagora se você quiser que ocorra a soma primeiro, apenas embrulhe" +
        " ela com parênteses dessa forma: (4 + 3) * 2"
      );
      Console.WriteLine("(4 + 3) * 2 == {0}", (4 + 3) * 2);
    }
  }
}
