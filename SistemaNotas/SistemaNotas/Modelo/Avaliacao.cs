
using SistemaNotas.Menus;


namespace SistemaNotas.Modelo
{
    internal class Avaliacao
    {
        double NotaFinal;
        public Aluno? Alunos { get; set; }
        public Materias? Materia { get; set; }

        public void CalcularNota(List<Aluno> ListaAlunos, List<Materias> ListaMaterias)
        {



           Console.WriteLine($"Qual o Id da Materia: ");
           foreach ( var materias in ListaMaterias )  { 
                
                
                Console.WriteLine($"As materias disponiveis são: ID: {materias.Id}, NOME:{materias.nome}");
                


            }
           int idMateria = int.Parse(Console.ReadLine()!);
            
            Materias materiaEscolhida = ListaMaterias.Find(Materia => Materia.Id == idMateria);
            if (materiaEscolhida != null)
            {



                Console.WriteLine("Qual é o Id do aluno: ");

                foreach (var alunos in ListaAlunos)
                {


                    Console.WriteLine($"os alunos matriculados: ID: {alunos.id}, NOME:{alunos.nome}");



                }



                int idAluno = int.Parse(Console.ReadLine()!);
                Aluno alunoSelecionado = ListaAlunos.Find(Aluno => Aluno.id == idAluno);
                if (alunoSelecionado != null)
                {




                    Console.WriteLine($"Qual a nota do aluno {alunoSelecionado.nome}, com matricula {alunoSelecionado.id} no primeiro Bimestre: ");
                    double NotaB1 = double.Parse(Console.ReadLine()!);
                    Console.WriteLine($"Qual a nota do aluno {alunoSelecionado.nome}, com matricula {alunoSelecionado.id} no Segundo Bimestre: ");
                    double NotaB2 = double.Parse(Console.ReadLine()!);
                    NotaFinal = (NotaB1 + NotaB2) / 2;
                    Console.WriteLine($"Nota total na materia de {materiaEscolhida.nome}:{NotaFinal} ");
                    Console.WriteLine("Nota Cadastrada com sucesso");
                    if (NotaFinal > 6)
                    {

                        Console.WriteLine($"{alunoSelecionado.nome} passou nesta materia!");

                    }
                    else
                    {

                        Console.WriteLine($"{alunoSelecionado.nome} reprovou nesta materia!");


                    }


                    Console.WriteLine("Gostaria de dar nota outro aluno? ");
                    Console.WriteLine("1: SIM ");
                    Console.WriteLine("2: Voltar a Menu ");
                    string? opcaoProfessor = Console.ReadLine()!;
                    int opcaoEscolhidaProfessor = int.Parse(opcaoProfessor);
                    switch (opcaoEscolhidaProfessor)
                    {
                        case 1:
                            Avaliacao avaliacao = new Avaliacao();
                            avaliacao.CalcularNota(Aluno.ListaAlunos, Materias.ListaMaterias);
                            break;

                        case 2: MenuPrincipal principal = new MenuPrincipal();
                            break;

                        default:
                            Console.WriteLine("Opção inválida.");
                            break;


                    }
                        

                    }





                else
                {
                    Console.WriteLine("Aluno não encontrado");



                }
            }

            else {
                Console.WriteLine("materia nao encontrada");
                    }





        }
  
    
  
    
    
    
  }



}

