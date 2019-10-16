using System;
using System.Linq;


namespace SoloLearn
{
  class Programa
  {
    static void Main()
    {
      int[] array = {2, 3, 4};
      Console.WriteLine("maior número do array: {0}", array.Max());
      Console.WriteLine("menor número do array: {0}", array.Min());
      Console.WriteLine("soma dos números do array: {0}", array.Sum());
    }
  }
}
