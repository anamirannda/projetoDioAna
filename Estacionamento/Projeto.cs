using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoDioAna.Estacionamento
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoHora = 0;
        private List<string> carros = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoHora)
        {
            this.precoInicial = precoInicial;
            this.precoHora = precoHora;
        }

        public void AdicionarCarro()
        {
            Console.WriteLine("Digite a placa do seu carro: ");
            string placa = Console.ReadLine();
            Console.WriteLine("Carro adicionado");
            carros.Add(placa);
        }

        public void RemoverCarro()
        {
            Console.WriteLine("Digite a placa do seu carro: ");
            string placa = Console.ReadLine();

            if (carros.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Quantas horas o seu veículo ficou estacionado: ");
                int hora = Convert.ToInt32(Console.ReadLine());
                decimal valor = precoInicial + precoHora * hora;

                Console.WriteLine($"O veículo de placa {placa} foi removido com sucesso. O valor a ser pago será de {valor}");
                carros.Remove(placa);
            }
            else
            {
                Console.WriteLine("Placa inválida, digite novamente");
            }
        }

        public void ListaCarro()
        {
            if (carros.Any())
            {
                foreach (var item in carros)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Não há carros cadastrados");
            }
        }
    }
    }
