using System;


# pragma warning disable 219
namespace SoloLearn
{
  class Animal
  {
    public Animal()
    {
      Console.WriteLine("Instância de animal criada.");
    }

    ~Animal()
    {
      Console.WriteLine("Instância de animal deletada.");
    }
  }

  class Cão: Animal
  {
    public Cão()
    {
      Console.WriteLine("Instância de Cão criada.");
    }

    ~Cão()
    {
      Console.WriteLine("Instância de Cão deletada.");
    }
  }

  class Programa
  {
    static void Main()
    {
      Cão laika = new Cão();
    }
  }
}
