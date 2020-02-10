using System;


namespace SoloLearn
{
  class Animal
  {
    public string Nome { get; set; }
    public int Idade { get; set; }
    public int pernas = 2;
    public int braços = 2;
    public int olhos = 2;
  }

  sealed class HumanoNormal: Animal
  {
    public string mutações = "nenhuma";
    public HumanoNormal(string nome, int idade)
    {
      Nome = nome;
      Idade = idade;
    }
  }

  sealed class HumanoChernobyl: Animal
  {
    public string mutações = "uma ou mais de uma";
    public HumanoChernobyl(string nome, int idade)
    {
      Nome = nome;
      Idade = idade;
    }
  }

  // class HerdandoErrado: HumanoNormal  // ou herdando de HumanoChernobyl.
  // {
  //   public string mutações = "tanto faz, é só um exemplo";
  // }

  // o código comentado acima irá gerar um erro.

  class Programa
  {
    static void Main()
    {
      HumanoNormal qualquerUm = new HumanoNormal("Qualquer Nome", 25);
      HumanoChernobyl qualquerOutro = new HumanoChernobyl("Qualquer Outro", 25);
      Console.WriteLine(
        "nome: {0}, mutações: {1}",
        qualquerUm.Nome,
        qualquerUm.mutações
      );
      Console.WriteLine(
        "nome: {0}, mutações: {1}",
        qualquerOutro.Nome,
        qualquerOutro.mutações
      );
    }
  }
}

// esse módulo contém código repetido pois estou aprendendo.
