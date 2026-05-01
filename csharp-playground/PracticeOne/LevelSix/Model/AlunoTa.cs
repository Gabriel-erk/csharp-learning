namespace Model
{
    public class AlunoTa
    {
        private string Nome { get; set; }
        private string Ra { get; set; }

        public void ExibirInformacoes()
        {
            System.Console.WriteLine($"Nome: {Nome}");
            System.Console.WriteLine($"RA: {Ra}");
        }
    }
}