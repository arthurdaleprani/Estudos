

namespace SistemaNotas.Modelo
{
    internal class Aluno
    {
        public int id { get; set; }
        public string? nome { get; set; }
        public int idade { get; set; }

        public static List<Aluno> ListaAlunos = new List<Aluno>()
      {

          new Aluno() { id = 1, nome = "Lucas", idade = 15},
          new Aluno() { id = 2, nome = "Jaime", idade = 16 },
          new Aluno() { id = 3, nome = "Sofia", idade = 15 },
          new Aluno() { id = 4, nome = "Arthur", idade = 15},
          new Aluno() { id = 5, nome = "Davi", idade = 16 },
          new Aluno() { id = 6, nome = "Luan", idade = 16 },
          new Aluno() { id = 7, nome = "Jean", idade =15 },
          new Aluno() { id = 8, nome = "Alberto", idade =15 },
          new Aluno() { id = 9, nome = "Romulo", idade = 16},
          new Aluno() { id = 10, nome = "Luciana", idade =16 },
          new Aluno() { id = 11, nome = "Geovana", idade =15 },


      };




    }
}
