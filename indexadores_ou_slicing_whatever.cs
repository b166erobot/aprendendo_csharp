using System;


namespace SoloLearn
{
  class Programa
  {
    static void Main()
    {
      string texto = "um texto qualquer";
      Console.WriteLine(
        "eu consigo acessar um caracter de um array string por index.\n" +
        "index 6: {0}",
        texto[6]
      );
      Console.WriteLine("ou acessar uma string em um array no index 2:");
      string[] array_string = {"texto 1", "texto 2", "texto 3"};
      Console.WriteLine(array_string[2]);
    }
  }
}
