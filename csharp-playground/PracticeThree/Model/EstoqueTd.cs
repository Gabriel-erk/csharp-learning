namespace ModelTd
{
    class EstoqueTd
    {
        public int QuantidadeMaxima { get; set; }
        public ProdutoTd Produto;
        private List<ProdutoTd> produtos = new List<ProdutoTd>();
        public double ValorTotalEstoque => produtos.Sum(produto => produto.Preco);    

        public void AddProduto(ProdutoTd produto)
        {
            produtos.Add(produto);
        }

        public void ExibirProdutosEmEstoque()
        {
            foreach (var produto in produtos)
            {
                System.Console.WriteLine($"Nome: {produto.Nome}");
                System.Console.WriteLine($"Valor: {produto.Preco}");
            }
            System.Console.WriteLine($"Valor total em estoque: R$ {ValorTotalEstoque}.");
        }
    }
}