using System;


namespace SoloLearn
{
  class Pessoa
  {
    protected int Idade { get; set; }
    protected string Nome { get; set; }
  }

  class Taubaté: Pessoa
  {
    public string barriga = "Gravidez genuína.";
    public Taubaté(string nome, int idade)
    {
      if (nome == "Barriga de Taubaté")
        this.barriga = "mulher de Taubaté com barriga falsa";
      Nome = nome;
      Idade = idade;
    }

    public void Barriga()
    {
      Console.WriteLine(
        "status: {0}, nome: {1}, idade: {2}", this.barriga, this.Nome,
        this.Idade
      );
    }
  }

  class Programa
  {
    static void Main()
    {
      Taubaté gravidaDeTaubaté = new Taubaté("Barriga de Taubaté", 36);
      Taubaté outraPessoa = new Taubaté("outra pessoa", 28);
      gravidaDeTaubaté.Barriga();
      outraPessoa.Barriga();
      // Console.WriteLine(gravidaDeTaubaté.Idade);

      // o código comentado acima irá gerar um erro
      // pois essa propriedade esta protegida.
    }
  }
}
