using System;


namespace SoloLearn
{
  class Programa
  {
    static void Main()
    {
      string texto = "Isso é um texto sobre cachorro. A palavra cachorro " +
                     "aparece nesse texto várias vezes.";
      texto = texto.Replace("cachorro", "gato");
      texto = texto.Substring(0, texto.IndexOf(".") + 1);
      Console.WriteLine(texto);
    }
  }
}
