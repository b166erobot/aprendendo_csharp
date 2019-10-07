using System;

namespace Teste{
  class Programa{
    static void Main(string[] args){
      string seuNome;
      Console.WriteLine("Qual e o seu nome?");
      seuNome = Console.ReadLine();
      Console.WriteLine("Ola {0}", seuNome);
    }
  }
}
