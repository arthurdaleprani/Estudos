﻿using SistemaNotas.Modelo;


void TelaInical()
{
     Console.WriteLine("Olá seja bem vindo ao sistema");
    




}


void Opcoes()
{
    Console.WriteLine("1: Para visualizar notas");
    Console.WriteLine("2: Adicionar Notas");
    Console.WriteLine("3:Sair");
    Console.WriteLine();
    string Opcaoescolha = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(Opcaoescolha);

    switch(opcaoEscolhidaNumerica) {

        case 1: Console.WriteLine();
                  break;


        case 2:
            Avaliacao avaliacao = new Avaliacao();
            avaliacao.CalcularNota(new List<Aluno>(), new List<Materias>());
            break;


        case 3: Console.WriteLine("Ate mais!");
                    break;

        default:
            Console.WriteLine("Opção inválida.");
            break;





    }



}
TelaInical();
Opcoes();