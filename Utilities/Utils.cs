using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioPOO.Models;

namespace trilha_net_POO_challenge.Utilities
{
    public class Utils
    {
        public static void ListarIhpones(List<Iphone> iphones)
        {
            if (iphones.Count == 0)
            {
                Console.WriteLine("Não há nenhum iphone cadastrado!");
                Thread.Sleep(2000);
            }
            else
            {
                int i = 0;
                foreach (var iphone in iphones)
                {
                    Console.WriteLine($"==== Iphone id: {i++} ====");
                    Console.WriteLine($"Número de telefone: {iphone.Numero}");
                }
            }
        }

        public static void ListarNokias(List<Nokia> nokias)
        {
            if (nokias.Count == 0)
            {
                Console.WriteLine("Não há nenhum nokia cadastrado!");
                Thread.Sleep(2000);
            }
            else
            {
                int i = 0;
                foreach (var nokia in nokias)
                {
                    Console.WriteLine($"==== Nokia id: {i++} ====");
                    Console.WriteLine($"Número de telefone: {nokia.Numero}");
                }
            }
        }

        public static bool VerificarNumero(List<Iphone> iphones, string numero)
        {
            if (numero.All(char.IsDigit) != true)
            {
                Console.WriteLine("Número inválido!\n");
                return false;
            }

            foreach (var iphone in iphones)
            {
                if (iphone.Numero == numero)
                {
                    Console.WriteLine("Número de telefone já existente\n");
                    return false;
                }
            }

            return true;
        }

        // Realizei a sobrecarga de método
        public static bool VerificarNumero(List<Nokia> nokias, string numero)
        {
            if (numero.All(char.IsDigit) != true)
            {
                Console.WriteLine("Número inválido!\n");
                return false;
            }

            foreach (var nokia in nokias)
            {
                if (nokia.Numero == numero)
                {
                    Console.WriteLine("Número de telefone já existente\n");
                    return false;
                }
            }

            return true;
        }

        public static Iphone CadastrarIphone(List<Iphone> iphones)
        {
            Console.Clear();
            Console.WriteLine("=== Cadastrando Iphone ===");

            string numero;
            do
            {
                Console.WriteLine("Insira o número de telefone: ");
                numero = Console.ReadLine();
            } while (VerificarNumero(iphones, numero) != true);

            Console.WriteLine("Insira o modelo do Iphone: ");
            string modelo = Console.ReadLine();

            Console.WriteLine("Insira o IMEI do Iphone");
            string imei = Console.ReadLine();

            Console.WriteLine("Insira a quantidade de mémoria do Iphone: ");
            int.TryParse(Console.ReadLine(), out int memoria);

            Console.WriteLine("Iphone cadastrado com sucesso!");
            Thread.Sleep(2000);

            return new Iphone(numero, modelo, imei, memoria);
        }

        public static Nokia CadastrarNokia(List<Nokia> nokias)
        {
            Console.Clear();
            Console.WriteLine("=== Cadastrando Nokia ===");

            string numero;
            do
            {
                Console.WriteLine("Insira o número de telefone: ");
                numero = Console.ReadLine();
            } while (VerificarNumero(nokias, numero) != true);

            Console.WriteLine("Insira o modelo do Nokia: ");
            string modelo = Console.ReadLine();

            Console.WriteLine("Insira o IMEI do Nokia");
            string imei = Console.ReadLine();

            Console.WriteLine("Insira a quantidade de mémoria do Nokia: ");
            int.TryParse(Console.ReadLine(), out int memoria);

            Console.WriteLine("Nokia cadastrado com sucesso!");
            Thread.Sleep(2000);

            return new Nokia(numero, modelo, imei, memoria);
        }
    }
}