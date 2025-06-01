using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioPOO.Models;
using trilha_net_POO_challenge.Utilities;

namespace trilha_net_POO_challenge.Services.NokiaServices
{
    public class NokiaServices
    {
        public static int SelecionarNokia(List<Nokia> nokias)
        {
            int id = 0;
            bool verificacao;

            do
            {
                Utils.ListarNokias(nokias);

                Console.WriteLine("Insira o Id do nokia que deseja utilizar:");
                verificacao = int.TryParse(Console.ReadLine(), out id);

                if (id < 0 || id > nokias.Count)
                {
                    verificacao = false;
                }

            } while (verificacao != true);

            return id;
        }

        public static void AlterarNumero(List<Nokia> nokias, Nokia nokia)
        {
            string numero;
            do
            {
                Console.WriteLine("Insira um novo número de telefone: ");
                numero = Console.ReadLine();
            } while (Utils.VerificarNumero(nokias, numero) != true);

            nokia.Numero = numero;
        }

        public static void InstalarApp(Nokia nokia)
        {
            Console.WriteLine("Digite o aplicativo que deseja instalar: ");
            string app = Console.ReadLine();

            nokia.InstalarAplicativo(app);

            for (int i = 5; i >= 1; i--)
            {
                Console.WriteLine($"Instalação concluída em: {i} segundos");
                Thread.Sleep(1000);
            }

            Console.WriteLine("Instalação concluída!\nPrecisone qualque tecla para retornar...");
            Console.ReadLine();
        }

        public static void RemoverNokia(List<Nokia> nokias, Nokia nokia)
        {
            nokias.Remove(nokia);

            for (int i = 3; i >= 1; i--)
            {
                Console.WriteLine($"Remoção concluída em: {i} segundos");
                Thread.Sleep(1000);
            }

            Console.WriteLine("Remoção concluída!\nPrecisone qualque tecla para retornar ao menu principal...");
            Console.ReadLine();
        }
    }
}