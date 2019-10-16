using System;


namespace SoloLearn
{
  class Pessoa
  {
    public string nome, gênero;
    public int idade;
    public Pessoa(string nome, int idade, string gênero)
    {
      this.nome = nome;
      this.idade = idade;
      this.gênero = gênero;
    }

    ~Pessoa()
    {
      Console.WriteLine("Instância de Pessoa <{0}> foi destruído.", this.nome);
    }
  }

  class Programa
  {
    static void Main()
    {
      Pessoa rafael = new Pessoa("rafael", 24, "Masculino");
      Pessoa rafaela = new Pessoa("rafaela", 24, "Feminino");
      Console.WriteLine("pessoas criadas: {0}, {1}", rafael.nome, rafaela.nome);

    }
  }
}
