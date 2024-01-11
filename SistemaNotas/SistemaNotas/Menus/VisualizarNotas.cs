using SistemaNotas.Modelo;

namespace SistemaNotas.Menus
{
    internal class VisualizarNotas
    {

        public Aluno? Alunos { get;}
        public Materias? Materia { get; set; }

        public Avaliacao? avaliacao { get; }

        public void VisualizarNota(List<Aluno> ListaAlunos, List<Materias> ListaMaterias)
        {
            Console.WriteLine("Qual Materia deseja verficar?");
     
            foreach (var materia in ListaMaterias)
            {
                Console.WriteLine($"{materia.Id}: {materia.nome}");


            }
            string? escolhaCliente = Console.ReadLine()!;
            int escolhaNum = int.Parse(escolhaCliente);
            Materias materiaEscolhida = ListaMaterias.Find((Materia => Materia.Id == escolhaNum));


            if (materiaEscolhida != null)
            {

                foreach(var alunoNota in ListaAlunos)
                {

                    if (alunoNota.notaFinal.TryGetValue(materiaEscolhida.Id, out double notaFinal))
                    {
                        Console.WriteLine($"{alunoNota.nome}, NOTA FINAL: {notaFinal}");
                    }
                    else
                    {
                        Console.WriteLine($"{alunoNota.nome}, NOTA FINAL: Não disponível");
                    }

                }


            }
            else
            {

                Console.WriteLine("Escolha Invalida");


            }

            Console.WriteLine("\nGostaria de Visualizar outra materia? ");
            Console.WriteLine("1: SIM ");
            Console.WriteLine("2: Voltar a Menu ");
            string? opcaoProfessor = Console.ReadLine()!;
            int opcaoEscolhidaProfessor = int.Parse(opcaoProfessor);
            switch (opcaoEscolhidaProfessor)
            {
                case 1:
                    VisualizarNotas visualizarNota = new VisualizarNotas();
                    visualizarNota.VisualizarNota(Aluno.ListaAlunos, Materias.ListaMaterias);
                    break;

                case 2:
                    MenuPrincipal principal = new MenuPrincipal();
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;


            }


        }


    }


    }

