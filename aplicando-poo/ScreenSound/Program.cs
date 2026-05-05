using Model;

Musica musica1 = new Musica();
musica1.Nome = "Roxanne";
musica1.Artista = "Ai so nibuligs";
musica1.Duracao = 5;
musica1.Disponivel = false;

Musica muscia2 = new Musica();
muscia2.Nome = "Addison rae";
muscia2.Artista = "The KID Laroi";
muscia2.Duracao = 3;
muscia2.Disponivel = false;

musica1.ExibirFichaTecnica();
System.Console.WriteLine("---------");
muscia2.ExibirFichaTecnica();

