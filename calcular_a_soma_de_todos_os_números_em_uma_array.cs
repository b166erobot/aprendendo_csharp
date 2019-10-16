using System;


namespace SoloLearn
{
  class Programa
  {
    static void Main()
    {
      int[] int_array = {11, 35, 62, 555, 989};
      int sum = 0;
      foreach (int x in int_array)
      {
        sum += x;
      }
      Console.WriteLine(sum); // saída == 1652.
    }
  }
}
