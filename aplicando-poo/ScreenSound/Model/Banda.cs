namespace Model
{
    class Banda
    {
        public string Nome { get;}
        private List<Album> albums = new List<Album>();

        public Banda(string nome)
        {
            Nome = nome;
        }
        
        public void AdicionarAlbum(Album album)
        {
            albums.Add(album);
        }

        public void ExibirDiscografia()
        {
            System.Console.WriteLine($"Discografia da banda: {Nome}");
            foreach (var album in albums)
            {
                System.Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
            }
        }
    }
}