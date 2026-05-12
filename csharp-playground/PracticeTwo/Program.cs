using System.Diagnostics.Contracts;
using ModelTc;

TitularTc titular = new TitularTc();
titular.Nome = "Gabriel";
ContaTc conta = new ContaTc();
conta.Agencia = "00001-90";
conta.NumeroConta = 1888890;
conta.Saldo = 1780.90;
conta.Limite = 2000;
conta.Titular = titular;

conta.ExibirInformacoesConta();
