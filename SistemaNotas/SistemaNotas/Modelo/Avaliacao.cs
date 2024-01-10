

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
                    Console.WriteLine($"Nota total na materia de {materiaEscolhida.nome}:{NotaFinal} " );
                    Console.WriteLine("Nota Cadastrada com sucesso");
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

