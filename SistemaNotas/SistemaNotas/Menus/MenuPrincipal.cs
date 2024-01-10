using SistemaNotas.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNotas.Menus
{
    internal class MenuPrincipal
    {

        public MenuPrincipal() {

            Console.WriteLine("Olá seja bem vindo ao sistema");


            Console.WriteLine("1: Para visualizar notas");
            Console.WriteLine("2: Adicionar Notas");
            Console.WriteLine("3:Sair");
            Console.WriteLine();
            string Opcaoescolha = Console.ReadLine()!;
            int opcaoEscolhidaNumerica = int.Parse(Opcaoescolha);

            switch (opcaoEscolhidaNumerica)
            {

                case 1:
                    Console.WriteLine();
                    break;


                case 2:
                    Avaliacao avaliacao = new Avaliacao();
                    avaliacao.CalcularNota(Aluno.ListaAlunos, Materias.ListaMaterias);
                    break;


                case 3:
                    Console.WriteLine("Ate mais!");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;





            }



        }


    }
}
