using System;


namespace SoloLearn
{
  class Programa
  {
    static void Main()
    {
      int[] array_int = new int[10];
      for (int k = 0; k < 10; k++)
      {
        array_int[k] = k * 2;
      }
      Console.WriteLine("[{0}]", String.Join(", ", array_int));
    }
  }
}
