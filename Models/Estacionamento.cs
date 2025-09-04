using System;
using System.Collections.Generic;
using System.Linq;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        //Preço fixo inicial
        private decimal precoInicial = 0;
        //Preço por hora
        private decimal precoPorHora = 0;

        // Lista de veículos estacionados
        private List<string> veiculos = new List<string>();

        // Construtor que recebe os valores iniciais

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        // Adiciona veículo à lista
        public void AdicionarVeiculo()
        {
            // Implementado!

            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
            Console.WriteLine($"Veículo {placa} adicionado com sucesso!");
        }

        // Remove veículo da lista e calcula o valor total
        public void RemoverVeiculo()
        {
            // Implementado!
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            // Verifica se o veículo existe

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = int.Parse(Console.ReadLine() ?? "0");
            
            //Calcula  o valor total a ser cobrado
                decimal valorTotal = precoInicial + precoPorHora * horas;
                veiculos.Remove(placa); // Remove o veículo da lista

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
            }
        }

        // Lista todos os veículos estacionados
        public void ListarVeiculos()
        {
            if (veiculos.Any()) // Verifica se há veículos na lista
            {
                Console.WriteLine("Os veículos estacionados são:");
                int contador = 1;
                foreach (var v in veiculos)
                {
                    Console.WriteLine($"{contador} - {v}");
                    contador++;
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
