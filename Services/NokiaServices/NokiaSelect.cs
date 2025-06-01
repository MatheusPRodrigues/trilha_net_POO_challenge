using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioPOO.Models;

namespace trilha_net_POO_challenge.Services.NokiaServices
{
    public class NokiaSelect
    {
        public static void SelectMenu(List<Nokia> nokias)
        {
            if (nokias.Count == 0)
            {
                Console.WriteLine("Cadastre um Nokia primeiro!");
                Thread.Sleep(2000);

                return;
            }

            int id = NokiaServices.SelecionarNokia(nokias);
            Nokia nokia = nokias[id];

            bool verificacao;
            do
            {
                Console.WriteLine("===== Nokia selecionado =====");
                Console.WriteLine($"Telefone: {nokia.Numero}");

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
                        NokiaServices.AlterarNumero(nokias, nokia);
                        Console.Clear();
                        break;
                    case 2:
                        nokia.Ligar();
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                    case 3:
                        nokia.ReceberLigacao();
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                    case 4:
                        NokiaServices.InstalarApp(nokia);
                        Console.Clear();
                        break;
                    case 5:
                        NokiaServices.RemoverNokia(nokias, nokia);
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