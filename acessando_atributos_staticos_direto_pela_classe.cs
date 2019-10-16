using System;


namespace SoloLearn
{
  class Gato
  {
    public static int contagem;
    public string nome, cor;
    public int idade;
    public Gato(string nome_, int idade_, string cor_)
    {
      nome = nome_;
      idade = idade_;
      cor = cor_;
      contagem++;
    }

    ~Gato()
    {
      Console.WriteLine("alguma instância da classe Gato foi destruida.");
    }
  }

  class Programa
  {
    static void Main()
    {
      Gato batman = new Gato("batman", 3, "branco");
      Gato coringa = new Gato("coringa", 3, "preto");
      Console.WriteLine("gatos: {0}, {1}", batman.nome, coringa.nome);

      Console.WriteLine(Gato.contagem);
    }
  }
}
