// para dizermos que estamos usando nosso namespace model
using System.ComponentModel;
using ModelExercicioConta;

ContaBancariaTa conta1 = new ContaBancariaTa();
conta1.id = 0;
conta1.titular = "Gabriel Erick";
conta1.saldo = 10000;
conta1.senha = 123456;

conta1.ExibirInformacoes();

