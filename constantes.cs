using System;


namespace Teste
{
  class Programa
  {
    static void Main()
    {
      Console.WriteLine(
        "Constantes armazenam um valor que não pode ser alterado " +
        "posteriormente.\nPor isso essa keyword recebe esse nome: const" +
        "const double pi = 3.14"
      );
      const double pi = 3.14;
      Console.WriteLine(
        "Caso você tente alterar o valor dessa variável, receberá um erro:\n" +
        "pi = 4.12"
      );
      Console.WriteLine("const double: {0}", pi);
    }
  }
}
