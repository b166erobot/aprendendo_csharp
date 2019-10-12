using System;


namespace Teste
{
  class Programa
  {
    static string converterParaString(int x)
    {
      return x.ToString();
    }

    static void Main()
    {
      string valor = converterParaString(444);
      Console.WriteLine(
        "este valor {0} foi convertido para string antes de ser imprimido",
        valor
      );
    }
  }
}
