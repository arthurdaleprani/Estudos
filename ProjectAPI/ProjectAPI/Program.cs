using ProjectAPI.Modelos;
using System.Text.Json;
using ProjectAPI.Filtros;

using (HttpClient client = new HttpClient())
{


    try
    {

        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        /*É comunicado que a lista de músicas pode ser nula.
        Para garantir que não seja nula, adicionamos um sinal de exclamação após a resposta da lista de músicas.
        Dessa forma, ao realizar o parsing, precisamos de uma classe que não seja nula para receber os dados.
        */

        //JsonSerializer.Deserialize Aqui voce pega um Json e tranforma ele em um objeto manipulavel

        ///musicas[0].InfoMusic();//Aqui consigo ver a primeira musica da lista 

        // LinqFiltro.FiltrarGeneros(musicas);

        // LinqOrder.ExibirArtistas(musicas);

        //LinqFiltro.FiltrarArtista(musicas, "pop");

        LinqFiltro.FiltrarMusicaArtista(musicas, "ZAYN");




    }
    catch (Exception ex)
    {



        Console.WriteLine($"Ocorreu um erro: {ex.Message }");
    }

    //try vai tentar algo, caso de errado catch

}
