using System;


namespace SoloLearn
{
  class Programa
  {
    static void Main()
    {
      int[,] array_multidimensional = new int[2, 4] {{4, 3, 2, 1}, {1, 2, 3, 4}};
      string primeiro_número = String.Join(", ", array_multidimensional[0, 0]);
      string segundo_número = String.Join(", ", array_multidimensional[1, 0]);
      Console.WriteLine("[{0}], [{1}]", primeiro_número, segundo_número);
    }
  }
}
