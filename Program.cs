using System.Numerics;
using DesafioPOO.Models;
using trilha_net_POO_challenge.Services.IphoneServices;
using trilha_net_POO_challenge.Services.NokiaServices;
using trilha_net_POO_challenge.Utilities;

public class Program
{
    public static void Main(string[] args)
    {
        List<Iphone> iphones = new List<Iphone>();
        List<Nokia> nokias = new List<Nokia>();

        bool verificacao;

        do
        {
            Console.WriteLine("======= Mural de Smartphones =======");
            Console.WriteLine("[1] - Adicionar um iphone");
            Console.WriteLine("[2] - Selecionar um iphone");
            Console.WriteLine("[3] - Adicionar um Nokia");
            Console.WriteLine("[4] - Selecinar um Nokia");
            Console.WriteLine("[0] - Encerrar\n: ");
            verificacao = int.TryParse(Console.ReadLine(), out int opcao);

            if (verificacao == false)
            {
                opcao = -1;
            }

            switch (opcao)
            {
                case 1:
                    iphones.Add(Utils.CadastrarIphone(iphones));
                    Console.Clear();
                    break;
                case 2:
                    IphoneSelect.SelectMenu(iphones);
                    Console.Clear();
                    break;
                case 3:
                    nokias.Add(Utils.CadastrarNokia(nokias));
                    Console.Clear();
                    break;
                case 4:
                    NokiaSelect.SelectMenu(nokias);
                    Console.Clear();
                    break;
                case 0:
                    Console.WriteLine("Programa encerrado!");
                    verificacao = false;
                    break;
                default:
                    verificacao = true;
                    break;
            }

        } while (verificacao);
    }
}
























/*
// TODO: Realizar os testes com as classes Nokia e Iphone
Iphone iphone = new Iphone("1234", "Modelo 1", "11111111", 128);

iphone.InstalarAplicativo("Telegram");
iphone.Ligar();
iphone.ReceberLigacao();

Nokia nokia = new Nokia("2345", "Modelo 2", "222222222", 64);

nokia.InstalarAplicativo("Whatsapp");
nokia.Ligar();
nokia.ReceberLigacao();
*/