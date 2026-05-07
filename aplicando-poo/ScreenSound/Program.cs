using Model;

Album albumDoQueen = new Album();
albumDoQueen.Nome = "A night at the opera";

Musica musica1 = new Musica();
musica1.Nome = "Love of my life";
musica1.Artista = "Queen";
musica1.Duracao = 10;
musica1.Disponivel = true;

Musica musica2 = new Musica();
musica2.Nome = "Bohemian Rhapsody";
musica2.Artista = "Queen";
musica2.Duracao = 10;
musica2.Disponivel = true;

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
