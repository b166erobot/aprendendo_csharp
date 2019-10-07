using System;


namespace Teste {
  class Programa{
    static void Main(){
      Console.WriteLine("Tipos de variáveis em csharp:");
      Console.WriteLine("string texto = \"um texto qualquer.\";");
      Console.WriteLine("int inteiro = 15;");
      Console.WriteLine("double pontoFlutuante = 19.04;");
      Console.WriteLine("char caracter = 'a';");
      Console.WriteLine("bool verdadeiroOuFalso = true;");
      string texto = "um texto qualquer.";
      int inteiro = 15;
      double pontoFlutuante = 19.04;
      char caracter = 'a';
      bool verdadeiroOuFalso = true;
      Console.WriteLine("\nSe você viu essa mensagem, então tudo funcionou!\n");
      Console.WriteLine("imprimindo os valores das respectivas variáveis:");
      Console.WriteLine("string: {0}", texto);
      Console.WriteLine("int: {0}", inteiro);
      Console.WriteLine("double: {0}", pontoFlutuante);
      Console.WriteLine("char: {0}", caracter);
      Console.WriteLine("bool: {0}", verdadeiroOuFalso);
    }
  }
}
