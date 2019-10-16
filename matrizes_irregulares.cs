using System;


namespace SoloLearn
{
  class Programa
  {
    static void Main()
    {
      int[][] matrix_irregular = new int[3][];
      int[][] matrix_irregular2 = new int[][]
      {
        new int[] {1,2,3,4,5,6},
        new int[] {2,3,4},
        new int[] {33, 42}
      };
      string array1 = String.Join(", ", matrix_irregular2[0]);
      Console.WriteLine(matrix_irregular);
      Console.WriteLine("[{0}]", array1);
    }
  }
}
