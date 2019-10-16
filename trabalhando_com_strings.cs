using System;


namespace SoloLearn
{
  class Programa
  {
    static void Main()
    {
      string texto = "um texto";
      Console.WriteLine("conteúdo da variável texto: \"{0}\"", texto);
      Console.WriteLine("tamanho do texto: {0}\n", texto.Length);
      Console.WriteLine("index do t: {0}\n", texto.IndexOf('t'));
      Console.WriteLine("inserindo algum texto a variável texto.");
      texto = texto.Insert(0, "Isso é ");
      Console.WriteLine(texto + '\n');
      Console.WriteLine("substituindo uma parte do texto.");
      texto = texto.Replace("Isso é", "eu sou");
      Console.WriteLine(texto + '\n');
      if (texto.Contains("texto"))
        Console.WriteLine("palavra 'texto' encontrada na variável texto.\n");
      Console.WriteLine("removendo caracteres no indice 4 em diante.");
      texto = texto.Remove(4);
      Console.WriteLine(": {0}\n", texto);
      Console.WriteLine(
        "recortando com o método substring. ele não serve para isso mas aqui " +
        "eu irei usar para isso por aprendizagem."
      );
      texto = texto.Substring(2);  // não sei o que faz ainda.
      Console.WriteLine(texto);
    }
  }
}
