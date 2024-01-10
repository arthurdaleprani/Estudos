using ProjectAPI.Modelos;
namespace ProjectAPI.Filtros;

internal class LinqFiltro
{

    public static void FiltrarGeneros(List<Musica> musicas) //Aqui a funcao ta recebendo uma lista de musicas
    {

        var todosGeneros = musicas.Select(generos => generos.Genero).Distinct().ToList(); //Aqui ele vai selecionar os Generos.
                                                                                          //Distinct é pra evitar que separe,
                                                                                         //tipo Rock com Rock classico, ambos sao rock.
        foreach (var generos in todosGeneros)
        {

            Console.WriteLine($"- {generos}");

        }
    }

    public static void FiltrarArtista(List<Musica> musicas, string genero)
    {


        /*var artistas = musicas.Select(artista => artista.Artista).Distinct().ToList();
        foreach (var artista in artistas)
        {   Console.WriteLine($"- {artista}");}
        isso foi oque tentei fazer mas deu errado kkkk
         */

        var artistaPorGenero = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica =>musica.Artista).Distinct().ToList();
        Console.WriteLine($"Artitas por Genero Musical >>>> {genero}");
        foreach (var artist in artistaPorGenero) { Console.WriteLine($"{artist}");
        } 
    
    }
    /*
     
    public static void FiltrarNome(List<Musica> musicas)
    {

        var nomeMusica = musicas.Select(nomeMusic => nomeMusic.Nome).Distinct().ToList();
        foreach (var nomeMus in nomeMusica)
        {  Console.WriteLine($"- {nomeMus}");
}

    }
    public static void FiltrarTempo(List<Musica> musicas)
    {
        var tempoMusica = musicas.Select(tempoMusic => tempoMusic.Duracao).Distinct().ToList();
        foreach (var tempo in tempoMusica)
        {

            Console.WriteLine($"- {tempo}");

        }


    }
    
     Tinha feito pra treinar
     
     
     */


    public static void FiltrarMusicaArtista(List<Musica> musicas, string nomeArtista)
    {

        var musicasDoArtista = musicas.Where(musicas => musicas.Artista!.Equals(nomeArtista)).ToList();
        Console.WriteLine(nomeArtista);
        foreach(var musica in musicasDoArtista)
        {

            Console.WriteLine($"- {musica.Nome}");


        }


    }



}





