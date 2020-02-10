using System;


#pragma warning disable 414
namespace SoloLearn
{
  class Pessoa
  {
    private readonly string nome, gênero;
    private readonly int idade;

    // construtor não pode ter um tipo como retorno?
    public Pessoa(string nome, int idade, string gênero)
    {
      this.nome = nome;
      this.idade = idade;
      this.gênero = gênero;
    }

    public string Nome
    {
      get { return nome; }
    }

    ~Pessoa()
    {
      Console.WriteLine("Instância de Pessoa <{0}> deletada.", this.nome);
    }
  }

  class Programa
  {
    static void Main()
    {
      Pessoa katia = new Pessoa("katia", 19, "Feminino");
      Pessoa tulio = new Pessoa("tulio", 19, "Masculino");
      Console.WriteLine("{0}, {1}", katia.Nome, tulio.Nome);
    }
  }
}
