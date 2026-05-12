namespace ModelTc
{
    class ContaTc
    {
        public string Agencia { get; set; }
        public int NumeroConta { get; set; }
        public double Saldo { get; set; }
        public double Limite { get; set; }
        public TitularTc Titular { get; set; }

        public void ExibirInformacoesConta()
        {
            System.Console.WriteLine($"Agência: {Agencia}.");
            System.Console.WriteLine($"Número da conta: {NumeroConta}.");
            System.Console.WriteLine($"Saldo: {Saldo}.");
            System.Console.WriteLine($"Limite: {Limite}.");
            System.Console.WriteLine($"Títular: {Titular}.");
        }
    }
}