using ProjectAPI.Modelos;

namespace ProjectAPI.Filtros;

internal class LinqOrder
{

    public static void ExibirArtistas(List<Musica> musicas)
    {

        var artistasOrdenados = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();//a gente orderna a musica com base no artista
        Console.WriteLine("Lista de artistas ordenados");
        foreach(var artist in artistasOrdenados) {
            Console.WriteLine($"-{artist}");
            
            
            
            }


    }







}
