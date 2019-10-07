using System;



namespace Teste
{
  class Programa
  {
    static void Main()
    {
      int x = 3;
      Console.WriteLine("int x = {0};", x);
      Console.WriteLine("Console.WriteLine(\"{0}\", --x);");
      Console.WriteLine("{0}", --x);
      Console.WriteLine("Console.WriteLine(\"{0}\", x--);");
      Console.WriteLine("{0}", x--);
    }
  }
}
