namespace ModelTa
{
    class ContaBancariaTa
    {
        public int id;
        public string titular;
        public float saldo;
        public float senha;

        public void ExibirInformacoes()
        {
            System.Console.WriteLine($"Número Indicador: {id}");
            System.Console.WriteLine($"Titular: {titular}");
            System.Console.WriteLine($"Saldo: {saldo}");
            System.Console.WriteLine($"Senha: {senha}");
        }
    }
}