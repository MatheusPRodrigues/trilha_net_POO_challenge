using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioPOO.Models;

namespace trilha_net_POO_challenge.Services.IphoneServices
{
    public class IphoneSelect
    {
        public static void SelectMenu(List<Iphone> iphones)
        {
            if (iphones.Count == 0)
            {
                Console.WriteLine("Cadastre um Iphone primeiro!");
                Thread.Sleep(2000);

                return;
            }

            int id = IphoneServices.SelecionarIphone(iphones);
            Iphone iphone = iphones[id];

            bool verificacao;
            do
            {
                Console.WriteLine("===== Iphone selecionado =====");
                Console.WriteLine($"Telefone: {iphone.Numero}");

                Console.WriteLine("\n[1] - Alterar número de telefone");
                Console.WriteLine("[2] - Realizar ligação");
                Console.WriteLine("[3] - Receber ligação");
                Console.WriteLine("[4] - Instalar aplicativo");
                Console.WriteLine("[5] - Descartar aparelho");
                Console.WriteLine("[0] - Voltar ao menu principal");
                verificacao = int.TryParse(Console.ReadLine(), out int opcao);

                if (verificacao == false)
                {
                    opcao = -1;
                }

                switch (opcao)
                {
                    case 1:
                        IphoneServices.AlterarNumero(iphone, iphones);
                        Console.Clear();
                        break;
                    case 2:
                        iphone.Ligar();
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                    case 3:
                        iphone.ReceberLigacao();
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                    case 4:
                        IphoneServices.InstalarApp(iphone);
                        Console.Clear();
                        break;
                    case 5:
                        IphoneServices.RemoverIphone(iphones, iphone);
                        verificacao = false;
                        break;
                    case 0:
                        verificacao = false;
                        break;                    
                    default:
                        verificacao = true;
                        Console.Clear();
                        break;
                }

            } while (verificacao);
        }
    }
}