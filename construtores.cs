using System;


namespace SoloLearn
{
  class Programa
  {
    class Pessoa
    {
      private int idade;
      private string nome;

      public Pessoa(string nome_, int idade_)
      {
        nome = nome_;
        idade = idade_;
      }

      public string obterNome()
      {
        return nome;
      }

      public int obterIdade()
      {
        return idade;
      }
    }

    static void Main()
    {
      Pessoa pessoa = new Pessoa("David", 18);
      Console.WriteLine(pessoa.obterNome());
      Console.WriteLine(pessoa.obterIdade());
    }
  }
}
