using System;
namespace Model
{
    class Musica
    {
        public string Nome { get; set; }
        public string Artista { get; set; }
        public int Duracao { get; set; }
        public bool Disponivel { get; set; }
        // nao é possivel realizar a "ESCRITA", ou seja, nao possui o "set" aqui, posso apenas "ler", ou seja, tenho apenas um método getter para a propriedade DescricaoResumida
        // funcao lambda, que nesse nosso caso abaixo equivale a escerver: public string DescricaoResumida { get { return => $"A música: {Nome} pertence ao artista {Artista}."} }, porém com lambda podemos resumir este processo, com essa funcao nao nomeada que por debaixo dos panos já nos traz um return com o conteúdo que desejarmos como se fosse na personalizacao do getter da propriedade
        public string DescricaoResumida => $"A música: {Nome} pertence ao artista {Artista}.";


        // criação de método em c#, usando modificador de acesso + tipo de retorno + nome do método
        public void ExibirFichaTecnica()
        {
            // para colocar váriaveis com texto no c# (ou seja, interpolação de string)== $"Nosso texto aqui: {variavel/atributo aqui}" 
            Console.WriteLine($"Nome: {Nome}");
            System.Console.WriteLine($"Artista: {Artista}");
            System.Console.WriteLine($"Duração em minutos: {Duracao}");
            if (Disponivel)
            {
                System.Console.WriteLine("Disponível no plano.");
            }
            else
            {
                System.Console.WriteLine("Não está disponível no plano.");
            }
        }
    }
}