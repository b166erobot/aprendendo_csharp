using System;


namespace SoloLearn
{
  class Banco
  {
    // só terei acesso a essa variável dentro dessa classe
    // mesmo que eu instâncie o objeto, não terei acesso a essa variável.
    private double saldo = 0;

    public void Deposito(double quantidade)
    {
      saldo += quantidade;
    }

    public void Saque(double quantidade)
    {
      saldo -= quantidade;
    }

    // só com um método ObterSaldo que conseguirei ter acesso a variável saldo.
    public double ObterSaldo()
    {
      return saldo;
    }
  }

  class Programa
  {
    static void Main()
    {
      Banco banco = new Banco();
      banco.Deposito(300);
      banco.Saque(42);
      Console.WriteLine(banco.ObterSaldo());
      // Console.WriteLine(banco.saldo);  // isso irá gerar um erro.
    }
  }
}
