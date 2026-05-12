using ModelTd;

ProdutoTd produtoUm = new ProdutoTd();
produtoUm.Nome = "X-burg"; 
produtoUm.Preco = 10.90;

ProdutoTd produtoDois = new ProdutoTd();
produtoDois.Nome = "X-salad"; 
produtoDois.Preco = 12.90;

ProdutoTd produtoTres = new ProdutoTd();
produtoTres.Nome = "X-tudo"; 
produtoTres.Preco = 15.90;

ProdutoTd produtoQuatro = new ProdutoTd();
produtoQuatro.Nome = "X-all"; 
produtoQuatro.Preco = 20.90;

EstoqueTd estoque = new EstoqueTd();
estoque.QuantidadeMaxima = 10;

estoque.AddProduto(produtoUm);
estoque.AddProduto(produtoDois);
estoque.AddProduto(produtoTres);
estoque.AddProduto(produtoQuatro);

estoque.ExibirProdutosEmEstoque();

