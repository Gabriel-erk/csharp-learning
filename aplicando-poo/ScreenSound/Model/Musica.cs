using System;
namespace Model
{
    class Musica
    {
        public string nome;
        public string artista;
        public int duracao;
        public bool disponivel;

        // criação de método em c#, usando modificador de acesso + tipo de retorno + nome do método
        public void ExibirFichaTecnica()
        {
            // para colocar váriaveis com texto no c# (ou seja, interpolação de string)== $"Nosso texto aqui: {variavel/atributo aqui}" 
            Console.WriteLine($"Nome: {nome}");
            System.Console.WriteLine($"Artista: {artista}");
            System.Console.WriteLine($"Duração em minutos: {duracao}");
            if (disponivel)
            {
                System.Console.WriteLine("Disponível no plano.");
            } else
            {
                System.Console.WriteLine("Não está disponível no plano.");
            }
        } 
    }
}