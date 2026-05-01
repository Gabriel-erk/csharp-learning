// para dizermos que estamos usando nosso namespace model
using System.ComponentModel;
using ModelTa;

System.Console.WriteLine("Exercício Conta Bancária");
ContaBancariaTa conta1 = new ContaBancariaTa();
conta1.id = 0;
conta1.titular = "Gabriel Erick";
conta1.saldo = 10000;
conta1.senha = 123456;

conta1.ExibirInformacoes();

System.Console.WriteLine("Exercício Carro");

CarroTa carro1 = new CarroTa();

carro1.nome = "Golf";
carro1.modelo = "Volkswagem";
carro1.marca = "Sei lá mano, não entendo de carro";

System.Console.WriteLine(carro1.Acelerar());
System.Console.WriteLine(carro1.Acelerar());
System.Console.WriteLine(carro1.Acelerar());
System.Console.WriteLine(carro1.Acelerar());

System.Console.WriteLine(carro1.Buzinar());

System.Console.WriteLine(carro1.Frear());
System.Console.WriteLine(carro1.Desacelerar());
System.Console.WriteLine(carro1.Desacelerar());
System.Console.WriteLine(carro1.Desacelerar());

System.Console.WriteLine(carro1.Frear());
