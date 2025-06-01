using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioPOO.Models;
using trilha_net_POO_challenge.Utilities;

namespace trilha_net_POO_challenge.Services.IphoneServices
{
    public class IphoneServices
    {
        public static int SelecionarIphone(List<Iphone> iphones)
        {
            int id = 0;
            bool verificacao;

            do
            {
                Utils.ListarIhpones(iphones);

                Console.WriteLine("Insira o Id do iphone que deseja utilizar:");
                verificacao = int.TryParse(Console.ReadLine(), out id);

                if (id < 0 || id > iphones.Count)
                {
                    verificacao = false;
                }

            } while (verificacao != true);

            return id;
        }

        public static void AlterarNumero(Iphone iphone, List<Iphone> iphones)
        {
            string numero;
            do
            {
                Console.WriteLine("Insira um novo número de telefone: ");
                numero = Console.ReadLine();
            } while (Utils.VerificarNumero(iphones, numero) != true);

            iphone.Numero = numero;
        }

        public static void InstalarApp(Iphone iphone)
        {
            Console.WriteLine("Digite o aplicativo que deseja instalar: ");
            string app = Console.ReadLine();

            iphone.InstalarAplicativo(app);

            for (int i = 5; i >= 1; i--)
            {
                Console.WriteLine($"Instalação concluída em: {i} segundos");
                Thread.Sleep(1000);
            }

            Console.WriteLine("Instalação concluída!\nPrecisone qualque tecla para retornar...");
            Console.ReadLine();
        }

        public static void RemoverIphone(List<Iphone> iphones, Iphone iphone)
        {
            iphones.Remove(iphone);

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