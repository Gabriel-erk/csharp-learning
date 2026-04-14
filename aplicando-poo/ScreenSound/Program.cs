using Model;

Musica musica1 = new Musica();
musica1.nome = "Roxanne";
musica1.artista = "Ai so nibuligs";
musica1.duracao = 5;
musica1.disponivel = true;

Musica muscia2 = new Musica();
muscia2.nome = "Addison rae";
muscia2.artista = "The KID Laroi";
muscia2.duracao = 3;
muscia2.disponivel = false;

musica1.ExibirFichaTecnica();
System.Console.WriteLine("---------");
muscia2.ExibirFichaTecnica();

