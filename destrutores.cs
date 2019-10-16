using System;


namespace SoloLearn
{
  class Cachorro
  {
    public string Nome, Raça;
    public int Idade;
    public Cachorro(string nome, int idade, string raça)
    {
      Nome = nome;
      Idade = idade;
      Raça = raça;
    }
    ~Cachorro()  // destrutor.
    {
      Console.WriteLine("Alguma instância de Cachorro foi destruida.");
    }
  }

  class Programa
  {
    static void Main()
    {
      Cachorro laika = new Cachorro("laika", 10, "basset + pinscher");
      Console.WriteLine(
        "nome: {0} idade: {1} raça: {2}", laika.Nome, laika.Idade, laika.Raça
      );
    }
  }
}
