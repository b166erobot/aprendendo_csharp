using System;


#pragma warning disable 219
namespace SoloLearn
{
  class Caixa
  {
    public int altura { get; set; }
    public int largura { get; set; }
    public Caixa(int a, int l)
    {
      altura = a;
      largura = l;
    }
  }

  class Programa
  {
    static void Main()
    {
      Caixa caixa1 = new Caixa(14, 3);
      Caixa caixa2 = new Caixa(5, 7);
      Console.WriteLine("nada a declarar, só leia o código.");
    }
  }
}
