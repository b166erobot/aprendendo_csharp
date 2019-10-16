using System;


namespace SoloLearn
{
  class Programa
  {
    static void Main()
    {
      int[] array_int = {1, 2, -1, 5, 99999999};
      string[] array_string = {"teste", "de", "array", "com", "strings"};
      double[] array_double = {0.2, 0.1, -2.0, 0.0};
      Console.WriteLine("[{0}]", String.Join(", ", array_int));
      Console.WriteLine("[{0}]", String.Join(", ", array_string));
      Console.WriteLine("[{0}]", String.Join(", ", array_double));
    }
  }
}
