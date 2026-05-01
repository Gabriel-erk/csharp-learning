namespace ModelTa
{
    public class PessoaTa
    {
        private string Nome { get; set; }
        private int Idade { get; set;}

        public void ExibirInformacoes()
        {
            System.Console.WriteLine($"Nome: {nome}");
            System.Console.WriteLine($"Idade: {Idade}");
        }
    }
}