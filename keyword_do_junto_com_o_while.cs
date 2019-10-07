using System;


namespace Teste
{
  class Programa
  {
    static void Main()
    {
      int a = 0;
      do
      {
        Console.WriteLine(a);
        a++;
      }
      while(a < 5);
      Console.WriteLine(
        "o do while irá executar primeiro o corpo da keyword do e depois " +
        "verificará a condição no while."
      );
    }
  }
}
