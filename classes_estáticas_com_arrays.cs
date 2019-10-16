using System;


namespace SoloLearn
{
  class Programa
  {
    static void Main()
    {
      int[] array = {1, 2, 3, 4};
      Console.WriteLine("array: [{0}] normal", String.Join(", ", array));
      Array.Reverse(array);
      Console.WriteLine("array: [{0}] com reverse", String.Join(", ", array));
      Array.Sort(array);
      Console.WriteLine("array: [{0}] com sort", String.Join(", ", array));
      string texto = "algum texto";
      string texto2 = "algum texto 2";
      Console.WriteLine(String.Concat(texto, texto2));
      Console.WriteLine(String.Equals(texto, texto2));
      Console.WriteLine(DateTime.Now);
      Console.WriteLine(DateTime.Today);
      Console.WriteLine(DateTime.DaysInMonth(2016, 2));
    }
  }
}
