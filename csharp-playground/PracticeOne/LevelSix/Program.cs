using ModelTa;

double stop = 0;

while (stop != 0)
{
    System.Console.WriteLine("=== Menu de opções ===");
    System.Console.WriteLine("23 - Classe Pessoa");
    System.Console.WriteLine("24 - Classe Produto");
    System.Console.WriteLine("25 - Sistema simples de alunos");
    System.Console.WriteLine("26 - Herança");
    System.Console.WriteLine("27 - Pagamento");
    System.Console.WriteLine("0 - Sair");
    System.Console.WriteLine("Informe a opção:");
    stop = int.Parse(Console.ReadLine());

    if (stop == 23)
    {
        PessoaTa pessoa;
        System.Console.WriteLine("Informe o nome da Pessoa:");
        pessoa.Nome = Console.ReadLine();
        System.Console.WriteLine("Informe a idade da pessoa:");
        pessoa.Idade = Console.ReadLine();

        pessoa.ExibirInformacoes();
    } else if (stop == 24)
    {
        ProdutoTa produto;
        System.Console.WriteLine("Informe o nome do produto:");
        produto.Nome = Console.ReadLine();
        System.Console.WriteLine("Informe o preço do produto:");
        produto.Preco = double.Parse(Console.ReadLine());

        produto.PrecoComDesconto();
    } else if (stop == 25)
    {
        List<AlunoTa> listaAlunos = new List<AlunoTa>();
        for (int i = 0; i < 4; i++)
        {
            System.Console.WriteLine("Informe o nome:");
            nomeAluno = Console.ReadLine();
            System.Console.WriteLine("Informe o RA:");
            raAluno = int.Parse(Console.ReadLine());
            listaAlunos.Add(new AlunoTa(nomeAluno, raAluno));
        }
    } else if (stop == 26)
    {
        
    } else if (stop == 27)
    {
        
    } else if (stop == 0)
    {
        stop = 0;
    }
    else
    {
        System.Console.WriteLine("Opção inválida.");
    }
}
