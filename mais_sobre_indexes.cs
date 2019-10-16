using System;


namespace SoloLearn
{
  class Clientes
  {
    private string[] nomes = new string[10];
    public string this[int index]
    {
      get { return nomes[index]; }
      set { nomes[index] = value; }
    }
  }

  class Programa
  {
    static void Main()
    {
      Clientes lista = new Clientes();
      lista[0] = "roberto";
      lista[1] = "igor";
      Console.WriteLine(lista[1]);
    }
  }
}
