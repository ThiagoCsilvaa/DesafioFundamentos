using DesafioFundamentos.Models;
using System;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

// solicita o preço inicial e o preço por hora
Console.WriteLine("Seja bem-vindo ao sistema de estacionamento!\n");

Console.WriteLine("Digite o preço inicial:");
decimal precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
decimal precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

bool exibirMenu = true;

// Realiza as operações do menu e o loop
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo(); // chama o método para adicionar veículo
            break;

        case "2":
            es.RemoverVeiculo(); // chama o método para remover veículo
            break;

        case "3":
            es.ListarVeiculos(); // chama o método para listar veículos
            break;

        case "4":
            exibirMenu = false; // encerra o loop
            break;

        default:
            Console.WriteLine("Opção inválida."); // mensagem de erro para opção inválida
            break;
    }

    if (exibirMenu)
    {
        Console.WriteLine("\nPressione uma tecla para continuar");
        Console.ReadKey(); // Pausa para o usuário ler mensagens
    }
}

Console.WriteLine("O programa se encerrou!");
