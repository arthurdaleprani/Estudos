using System.Data.Common;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json.Serialization;

namespace ProjectAPI.Modelos
{
    internal class Musica
    {
        [JsonPropertyName("Song")]
        public string? Nome { get; set; }

        [JsonPropertyName("artist")]
        public string? Artista  { get; set; }

        [JsonPropertyName("duration_ms")]
        public int Duracao { get; set; }

        [JsonPropertyName("genre")]
        public string? Genero { get; set; }


        public void InfoMusic()
        {
            Console.WriteLine($"Musica: {Nome}");
            Console.WriteLine($"Artista: { Artista}");
            Console.WriteLine($"Duração: {Duracao}");
            Console.WriteLine($"Genero: {Genero}");


        }


        
    }
    
}

