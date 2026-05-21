using System;
using System.Collections.Generic;
using System.Linq;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");

            // Lê a matrícula introduzida pelo utilizador e guarda-a
            string placa = Console.ReadLine();

            // Adiciona a matrícula à lista de veículos
            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Lê a matrícula introduzida pelo utilizador
            string placa = Console.ReadLine();

            // Verifica se o veículo existe (comparando tudo em maiúsculas para evitar erros)
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // Lê o texto da consola e converte-o para um número inteiro
                int horas = int.Parse(Console.ReadLine());

                // Realiza o cálculo do preço total
                decimal valorTotal = precoInicial + (precoPorHora * horas);

                // Como a verificação aceita maiúsculas/minúsculas, localizamos o registo exato guardado na lista para o remover
                string veiculoARemover = veiculos.First(x => x.ToUpper() == placa.ToUpper());
                veiculos.Remove(veiculoARemover);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                // Utiliza um laço foreach para percorrer e exibir cada veículo da lista
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}