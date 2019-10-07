using System;


namespace Teste
{
  class Programa
  {
    static void Main()
    {
      int a = 0;
      int b = a;
      if (a == b)
      Console.WriteLine("variável 'a' é igual a 'b'");
      a = 1;
      if (a != b)
      Console.WriteLine("variável 'a' é diferente de 'b'");
      if (a >= b)
      Console.WriteLine("variável 'a' é maior ou igual a 'b'");
      if (b <= a)
      Console.WriteLine("variável 'b' é menor ou igual a 'a'");
      if (a > b)
      Console.WriteLine("variável 'a' é maior que 'b'");
      if (b < a)
      Console.WriteLine("variável 'b' é menor que 'a'");
    }
  }
}
