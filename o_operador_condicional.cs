using System;


namespace Teste
{
  class ARespostaParaOSentidoDaVidaOUniversoETudoMais
  {
    static void Main()
    {
      int calculo = 42;
      string mensagem;
      // if (calculo <= 41)
      //   mensagem = "resposta está sendo calculada";
      // else
      //   mensagem = "não pode haver a pergunta e a resposta no mesmo universo.";
      mensagem = (calculo <= 41) ? "calculando" : "42";
      Console.WriteLine(mensagem);
    }
  }
}
