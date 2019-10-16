using System;


namespace SoloLearn
{
  class Cachorro
  {
    public string nome, raça;
    public int idade;
    public Cachorro(string nome_, int idade_, string raça_)
    {
      nome = nome_;
      raça = raça_;
      idade = idade_;
      Console.WriteLine("construtor executado.");
    }
    ~Cachorro()
    {
      Console.WriteLine("destrutor executado.");
    }
  }

  class Programa
  {
    static void Main()
    {
      Cachorro laika = new Cachorro("laika", 10, "basset");
      Console.WriteLine(
        "nome: {0}, idade: {1}, raça: {2}", laika.nome, laika.idade, laika.raça
      );
    }
  }
}
