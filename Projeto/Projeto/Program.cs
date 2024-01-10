using System;
using System.Net;

string mensagemInicial = "Bem vindo a sua plataforma de Jogos";
string tituloSistema = @"
░█▀▀█ █▀▀█ █▀▄▀█ █▀▀ ░█─░█ █▀▀█ █▀▀█ █▀▀▄ 
░█─▄▄ █▄▄█ █─▀─█ █▀▀ ░█▀▀█ █▄▄█ █▄▄▀ █──█ 
░█▄▄█ ▀──▀ ▀───▀ ▀▀▀ ░█─░█ ▀──▀ ▀─▀▀ ▀▀▀─";

List<string> games = new List<string> {"CS2", "EAFC24"};




void ExibirMensagemInicial()
{
    Console.WriteLine(tituloSistema);
    Console.WriteLine(mensagemInicial);
}

     void OpcoesMenu()
{
    Console.WriteLine("Digite 1 para ver os jogos disponiveis");
    Console.WriteLine("Digite 2 para adicionar um jogo");
    Console.WriteLine("Digite 3 para sair");
    Console.Write("Qual é a sua opção: ");
    string opcao = Console.ReadLine()!;
    int opcaoEscolhida = int.Parse(opcao);
    

    switch (opcaoEscolhida)
    {
        case 1: Console.WriteLine("Aqui está os jogos " + games ); 
            break; 

        case 2: Console.WriteLine("Ok,vamos adicionar novos jogos");
            break;

        case 3 : Console.WriteLine("Até a proxima (:");
            break;

        default: Console.WriteLine("Não entendi oque voce quis dizer /:");
            break;


    }
    

}

     void NewGame()
{
    Console.Clear();
    Console.WriteLine("Registro de jogos");
    Console.WriteLine("Digite o Nome e Genero");
    string nomeGame = Console.ReadLine()!;
    string generoGame = Console.ReadLine()!;
    games.Add(nomeGame);
    Console.WriteLine($"{nomeGame} {generoGame}"); Console.WriteLine("Novo jogo registrado");
    Thread.Sleep(2000);
    Console.Clear() ;
    OpcoesMenu();




}


void MostrasGames()
{
Console.Clear();
    Console.WriteLine("Exibindo Games");
    /*for (int i = 0; i < games.Count; i++)
    {
        Console.WriteLine($"Games: {games[i]}");
    } */
    
    foreach (string game in games)
    {
        Console.WriteLine($"Game: {game}");
    }


    Console.WriteLine("Aperte Qualquer tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    OpcoesMenu();

}


ExibirMensagemInicial();
OpcoesMenu();
NewGame();
MostrasGames();