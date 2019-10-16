using System;


namespace SoloLearn
{
  class Gato
  {
    public static int contagem = 0;
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
      Console.WriteLine("alguma instância da classe gato foi destruída.");
    }
  }

  class Programa
  {
    // tudo o que é statico pertence a própria classe.
    // portanto, haverá somente um item (variável, propriedade, método) único
    // caso seja usado com void.
    static void Main()
    {
      Gato peludinho = new Gato("peludinho", 1, "amarelo");
      Console.WriteLine("nome do gato: {0}", peludinho.nome);
      Gato bolinha = new Gato("bolinha", 1, "cinza");
      Console.WriteLine("nome da gata: {0}", bolinha.nome);
      Console.WriteLine("contagem de gatos: {0}", Gato.contagem);
    }
  }
}
