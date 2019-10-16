using System;


namespace SoloLearn
{
  class Programa
  {
    static void Main()
    {
      int[] array = {2, 3, 4};
      Console.WriteLine("length {0}, rank {1}", array.Length, array.Rank);
      for (int k=0; k<array.Length; k++)
      {
        Console.WriteLine(array[k]);
      }
    }
  }
}
