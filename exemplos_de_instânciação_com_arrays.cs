using System;


namespace SoloLearn
{
  class Programa
  {
    public static void InstânciaComArrays()
    {
      string[] names = new string[3] {"John", "Mary", "Jessica"};
      double[] prices = new double[4] {3.6, 9.8, 6.4, 5.9};
      Console.WriteLine("[{0}]", string.Join(", ", names));
      Console.WriteLine("[{0}]", string.Join(", ", prices));
    }

    public static void InstânciaComArrays2()
    {
      string[] names = new string[] {"John", "Mary", "Jessica"};
      double[] prices = new double[] {3.6, 9.8, 6.4, 5.9};
      Console.WriteLine("[{0}]", string.Join(", ", names));
      Console.WriteLine("[{0}]", string.Join(", ", prices));
    }

    public static void InstânciaComArrays3()
    {
      string[] names = {"John", "Mary", "Jessica"};
      double[] prices = {3.6, 9.8, 6.4, 5.9};
      Console.WriteLine("[{0}]", string.Join(", ", names));
      Console.WriteLine("[{0}]", string.Join(", ", prices));
    }

    static void Main()
    {
      InstânciaComArrays();
      Console.WriteLine();
      InstânciaComArrays2();
      Console.WriteLine();
      InstânciaComArrays3();
    }
  }
}
