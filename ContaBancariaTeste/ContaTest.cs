using ContaBancaria.Models;

namespace ContaBancariaTeste;

public class ContaTest
{
    [Fact]
    public void DepositarNaContaComSucesso()
    {
        //Arrenge
        var numeroConta = 123456;
        var saldo = 100.0m;
        var deposito = 25.25m;

        //Act
        var contaCorrente = new ContaCorrente(numeroConta, saldo);
        contaCorrente.Creditar(deposito);
        var novoSaldo = contaCorrente.RetornaSaldo();

        //Assert
        Assert.Equal(novoSaldo, saldo + deposito);

    }

    [Fact]
    public void SacarDaContaComSucesso()
    {
        //Arrenge
        var numeroConta = 123456;
        var saldo = 100.0m;
        var saque = 25.0m;

        //Act
        var contaCorrente = new ContaCorrente(numeroConta, saldo);
        contaCorrente.Sacar(saque);
        var novoSaldo = contaCorrente.RetornaSaldo();

        //Assert
        Assert.Equal(novoSaldo, saldo - saque);

    }
}