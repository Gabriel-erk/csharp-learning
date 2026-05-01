namespace ModelTa
{
    public class ProdutoTa
    {
        private string Nome { get; set; }
        private double Preco { get; set; }

        public void PrecoComDesconto()
        {
            Preco -= Preco * 0.10;
            System.Console.WriteLine($"Produto: {Nome} Valor com desconto (10%): {Preco}"); 
        }
    }
}