using System;


namespace Teste{
  class Programa{
    static void Main(string[] args){
      Console.WriteLine("Quantos anos você tem?");
      int idade = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Você tem {0} anos", idade);
    }
  }
}
