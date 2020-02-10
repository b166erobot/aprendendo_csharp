using System;


// #pragma warning disable 219, 414
namespace SoloLearn
{
  class Caixa
  {
    public static int contagem = 0;
    public int altura, largura, numero;

    public Caixa(int altura, int largura)
    {
      this.altura = altura;
      this.largura = largura;
      contagem++;
      this.numero = contagem;
    }

    public static Caixa operator + (Caixa x, Caixa y)
    {
      Caixa nova_caixa = new Caixa(x.altura + y.altura, x.largura + y.largura);
      return nova_caixa;
    }

    ~Caixa()
    {
      Console.WriteLine(
        "Instância de Caixa número {0} destruído.", this.numero
      );
    }
  }

  class Programa
  {
    static void Main()
    {
      Caixa caixa1 = new Caixa(4, 2);
      Caixa caixa2 = new Caixa(3, 5);
      Caixa caixa3 = caixa1 + caixa2;
      Console.WriteLine(
        "altura {0}, largura {1}", caixa3.altura, caixa3.largura
      );
    }
  }
}
