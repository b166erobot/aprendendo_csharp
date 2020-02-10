using System;


namespace SoloLearn
{
  class Shape
  {
    public virtual void Desenhar()
    {
      Console.WriteLine("desenhando");
    }
  }

  class Circulo: Shape
  {
    public override void Desenhar()
    {
      Console.WriteLine("desenhando um circulo");
    }
  }

  class Retângulo: Shape
  {
    public override void Desenhar()
    {
      Console.WriteLine("desenhando um retângulo");
    }
  }

  class Programa
  {
    static void Main()
    {
      Shape circulo = new Circulo();
      Shape retângulo = new Retângulo();
      Shape shape = new Shape();
      circulo.Desenhar();
      retângulo.Desenhar();
      shape.Desenhar();
    }
  }
}
