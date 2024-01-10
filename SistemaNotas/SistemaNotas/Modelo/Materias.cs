
namespace SistemaNotas.Modelo
{
    internal class Materias
    {
        public int Id{ get; set; }
        public string? nome { get; set; }
       

        public static List<Materias> ListaMaterias = new List<Materias>
      {
          new Materias{Id = 1 , nome = "Biologia" },
          new Materias{Id = 2 , nome = "Matematica", },
          new Materias{Id = 3, nome = "Portugues" },
          new Materias {Id =4 , nome = "Fisica" },
          new Materias {Id = 5, nome = "Quimica"},
          new Materias {Id = 6, nome = "EdFisica" },
          new Materias {Id = 7 , nome = "Filosofia" },



      };
       
       

    }
}
