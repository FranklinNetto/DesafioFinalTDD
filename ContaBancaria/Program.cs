
using ContaBancaria.Models;

var numeroConta = 778899;
var saldo = 1000.0m;

var contaCorrente = new ContaCorrente(numeroConta, saldo);

var saldoAtual = contaCorrente.RetornaSaldo();

Console.WriteLine($"O saldo inicial é de {saldoAtual}");

contaCorrente.Creditar(200.0m);

saldoAtual = contaCorrente.RetornaSaldo();

Console.WriteLine($"O saldo com depósito de 20% é de {saldoAtual}");

contaCorrente.Sacar(600.0m);

saldoAtual = contaCorrente.RetornaSaldo();

Console.WriteLine($"O saldo com saque de 50% de {saldoAtual}");

