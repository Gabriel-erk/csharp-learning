using Model;

Album albumDoQueen = new Album("A night at the opera");

Banda queen = new Banda("Queen");

Musica musica1 = new Musica(queen, "Love of my life");
musica1.Duracao = 213;
musica1.Disponivel = true;

Musica musica2 = new Musica(queen, "Bohemian Rhapsody");
musica2.Duracao = 354;
musica2.Disponivel = true;

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
// albumDoQueen.ExibirMusicasDoAlbum();

queen.AdicionarAlbum(albumDoQueen);
queen.ExibirDiscografia();

