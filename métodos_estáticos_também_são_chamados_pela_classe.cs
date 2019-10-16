using System;


namespace SoloLearn
{
  class Cachorro
  {
    public string nome, cor;
    public int idade;
    public Cachorro(string nome_, int idade_, string cor_)
    {
      nome = nome_;
      idade = idade_;
      cor = cor_;
    }

    public static void Latir()
    {
      Console.WriteLine("Auau!");
    }

    ~Cachorro()
    {
      Console.WriteLine("alguma instância de Cachorro foi destruída.");
    }
  }

  class Programa
  {
    static void Main()
    {
      Cachorro laika = new Cachorro("laika", 10, "amarelo");
      Console.WriteLine("nome da cachorrinha: {0}", laika.nome);
      Cachorro.Latir();
    }
  }
}
