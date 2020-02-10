using System;


namespace SoloLearn
{
  class Animal
  {
    public string Nome { get; set; }
    public int Patas { get; set; }
    public int Idade { get; set; }
  }

  class Cão: Animal
  {
    public Cão(string nome, int idade)
    {
      Nome = nome;
      Idade = idade;
      Patas = 4;
    }

    public void Latir()
    {
      Console.WriteLine("Auau!");
    }

    ~Cão()
    {
      Console.WriteLine(
        "Uma instância de Cão <{0}> foi destruida.", this.Nome
      );
    }
  }

  class Programa
  {
    static void Main()
    {
      Cão laika = new Cão("laika", 10);
      laika.Latir();
    }
  }
}
