using System;



namespace Teste
{
  class Programa
  {
    static void Main()
    {
      int vezes_rodado = 0;
      int somatório = 1;
      while(somatório++ < 5)
      {
        if (somatório % 2 == 0)
        somatório += 2;

        ++vezes_rodado;
      }
      Console.WriteLine("o loop rodou {0} vezes.", vezes_rodado);
      Console.WriteLine(
        "\nexplicação: a primeira vez o loop roda e a comparação aritimética " +
        "é 1 < 5, retornando true e nada acontece, fejoada. a segunda vez, a " +
        "comparação aritimética é 2 < 5 retornando true e o somatório é " +
        "acrescentado + 2 resultando em 4. na terceira vez o loop faz " +
        "a comparação aritimética de 5 < 5 e retorna false. portanto, o " +
        "programa não entra no corpo do while na terceira vez."
      );
    }
  }
}
