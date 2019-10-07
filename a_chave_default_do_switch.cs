using System;



namespace Teste
{
  class Programa
  {
    static void Main()
    {
      int idade = 88;
      switch (idade)
      {
        case 16:
          Console.WriteLine("muito jovem");
          break;
        case 42:
          Console.WriteLine("adulto");
          break;
        case 70:
          Console.WriteLine("idoso");
          break;
        default:
          Console.WriteLine("o caso default");
          break;
      }
    }
  }
}
