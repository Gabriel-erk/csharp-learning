namespace Model
{
    class Album
    {
        private List<Musica> musicas = new List<Musica>();
        public string Nome { get; set; }
        // uso de lambda (ou no js == arrow function) onde retorno para a propriedade de "somente leitura" Duracao total a SOMA da duraćão de todas as músicas presentes na minha lista musicas (somente leitura pois quando eu uso uma lambda dessa forma, internamente, apenas o método GET é definido, logo, então, essa expressão lambda abaixo equivale ao novo GET da minha propriedade DuracaoTotal)\\
        // Sum == método que realiza soma dos valores de uma lista onde seu primeiro parâmetro é uma funćão, que passamos uma lambda que percorre a lista que chamou o método Sum (== musicas), chamamos cada iteraćão em musicas de: musica e vamos realizando a soma do valor de cada música que passa para no fim retornarmos o valor total para DuracaoTotal
        public int DuracaoTotal => musicas.Sum(musica => musica.Duracao);

        public void AdicionarMusica(Musica musica)
        {
            musicas.Add(musica);
        }

        public void ExibirMusicasDoAlbum()
        {
            System.Console.WriteLine($"Lista de músicas do álbum {Nome}:");
            foreach (var musica in musicas)
            {
                System.Console.WriteLine($"Música: {musica.Nome}");
            }
            System.Console.WriteLine($"Para ouvir este álbum ianteiro você precisa de {DuracaoTotal} segundos.");
        }
    }
}