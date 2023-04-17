using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EXERCÍCIO 1
            // int c;
            // 1- FALSA, pois o int não consegue ler o número após a virgula. Não tem como converter uma para outra, pois existe uma conversão explícita para isso
            // c = float.Parse(Console.ReadLine());
            // Quando se está usando o float é possível incluir o int

            // ------------------------------------------------ -------------------------------------------------- -------------------------------------------------- --------

            // EXERCÍCIO 2

            // o ConsoleReadLine() é usado para ler uma linha de código inteira do arquivo ele restaurar o caractere digitado pelo usuário. já o Console.Read é para ler um caractere, usado para algo mais preciso. Ele retornará em ASCII um número da linguagem em ASCII. Ele sempre é do mesmo tipo


            // ------------------------------------------------ -------------------------------------------------- -------------------------------------------------- ----------

            // EXERCÍCIO 3

            // é bom vc ler bem o exercício, pois tem que ficar atento porque essas variáveis ​​só leem números, a float le apenas um após a virgula, já o double le 2 ou mais

            // ------------------------------------------------ -------------------------------------------------- -------------------------------------------------- ----------

            // EXERCÍCIO 4


            // int num, num2, num3;
            // Console.WriteLine("Entre com um numero: ");
            // num = int.Parse(Console.ReadLine());
            // num2 = num / 2;
            // num3 = num % 2;
            // if (num3 == 0 && num2 * 2 > 10)
            // Console.WriteLine("Mensagem 1");
            // senão
            // Console.WriteLine("Mensagem 2");
            // Console.ReadKey();
            // ao entrar com o número 2 a mensagem foi 8, ao entrar com 27 a mensagem foi 2, ao entrar com o 28 a mensagem foi 1

            // ------------------------------------------------ ------

            // EXERCÍCIO 5

            // flutua s, t, v, então;
            // Console.WriteLine("digite a vaelocidade");
            // v = float.Parse(Console.ReadLine());
            // Console.WriteLine("digite a posição inicial");
            // so = float.Parse(Console.ReadLine());
            // Console.WriteLine("digite o instante");
            // T = float.Parse(Console.ReadLine());
            // s = so + v * t;
            // Console.WriteLine("a posição final é" + s);
            // Console.ReadKey();

            // ================================================ =====================================

            // EXERCÍCIO 6

            // int num;

            // Console.WriteLine("qual o número desejado:");
            // num = int.Parse(Console.ReadLine());

            // if (num % 3 == 0 && num % 5 == 0 && num % 10 == 0)
            //      Console.WriteLine("o número é divisível por 3,5 e 10");
            // else if (num % 3 == 0 && num % 5 == 0 && num % 10 != 0)
            // {

            //      Console.WriteLine("o número é divisível por 3 e 5 ");
            // }
            // else if (num % 3 == 0 && num % 5 != 0 && num % 10 != 0)
            // {

            //      Console.WriteLine("o número é divisível apenas por 3");
            // }
            // else if (num % 3 != 0 && num % 5 == 0 && num % 10 != 0)
            // {

            //      Console.WriteLine("o número é divisível apenas por 5");
            // }


            // ================================================ ========================================

            // EXERCÍCIO 7

            // int km, Ekm = 100, distancia, diferença;

            // Console.WriteLine("Digite o km onde sua casa está localizada: ");
            // km = int.Parse( Console.ReadLine() );

            // diferença = Ekm - km;

            // if(diferença >= 0 && diferença <= 12)
            // {
            //     Console.WriteLine("O tempo necessário é de 14 minutos");
            // }
            // else if(diferença > 12 && diferença <= 29)
            // {
            //     distancia = 14 + 17;
            //     Console.WriteLine("O tempo necessário é de " + distancia + " minutos");
            // }
            // else if(diferença > 29 && diferença <= 55)
            // {
            //     distancia = 14 + 17 + 13;
            //     Console.WriteLine("O tempo necessário é de " + distancia + " minutos");
            // }
            // else if(diferença > 55 && diferença <= 82)
            // {
            //     distancia = 14 + 17 + 13 + 15;
            //     Console.WriteLine("O tempo necessário é de " + distancia + " minutos");
            // }
            // else if(diferença > 82 && diferença <= 100)
            // {
            //     distancia = 14 + 17 + 13 + 15 + 12;
            //     Console.WriteLine("O tempo necessário é de " + distancia + " minutos");
            // }
            // Console.ReadKey();

            // ================================================ ========================================

            // EXERCÍCIO 8

            // Console.WriteLine("Atividade 8.");
            // Console.WriteLine("");

            // float produto, lucLiq, marca, LucT;
            // Console.WriteLine("=====MENU====");
            // Console.WriteLine("1- ROYAL");
            // Console.WriteLine("2- WISKAS");
            // Console.WriteLine("3- GOLDEN");
            // Console.WriteLine("4- NUTRIEN");
            // Console.WriteLine("5- SPECIALCAT");
            // Console.WriteLine("6-MARBA");
            // Console.WriteLine("7-GATUS");
            // Console.WriteLine("Digite a quantidade de unidades de um produto: ");
            // prod = int.Parse(Console.ReadLine());
            // Console.WriteLine("Digite a marca do produto: ");
            // marc = int.Parse(Console.ReadLine());

            // troca (marca)
            // {
            //     caso 1:
            //         LucT = produto * 129.50f;
            //         lucLiq = ((LucT - (77.5f / 100)) - (33 / 100));
            //         Console.WriteLine("Valor total: " + LucT + " e lucro líquido: " + LucLiq);
            //         quebra;
            //     caso 2:
            //         LucT = produto * 182.78f;
            //         lucLiq = ((LucT - (89.7f / 100)) - (27.5f / 100));
            //         Console.WriteLine("Valor total: " + LucT + " e lucro líquido: " + LucLiq);
            //         quebra;
            //     caso 3:
            //         LucT = produto * 159.46f;
            //         lucLiq = ((LucT - (71.7f / 100)) - (22.5f / 100));
            //         Console.WriteLine("Valor total: " + LucT + " e lucro líquido: " + LucLiq);
            //         quebra;
            //     caso 4:
            //         LucT = produto * 144.80f;
            //         lucLiq = ((LucT - (88.9f / 100)) - (25 / 100));
            //         Console.WriteLine("Valor total: " + LucT + " e lucro líquido: " + LucLiq);
            //         quebra;
            //     caso 5:
            //         LucT = produto * 205.40f;
            //         lucLiq = ((LucT - (83.24f/100)) - (22/100));
            //         Console.WriteLine("Valor total: " + LucT + " e lucro líquido: " + LucLiq);
            //         quebra;
            //     caso 6:
            //         LucT = produto * 125.10f;
            //         lucLiq = ((LucT - (90,4f / 100)) - (17,9 / 100));
            //         Console.WriteLine("Valor total: " + LucT + " e lucro líquido: " + LucLiq);
            //         quebra;
            //     caso 7:
            //         LucT = produto * 133.99f;
            //         lucLiq = ((LucT - (94.6f / 100)) - (20 / 100));
            //         Console.WriteLine("Valor total: " + LucT + " e lucro líquido: " + LucLiq);
            //         quebra;
            //     padrão:
            //         Console.WriteLine("Valor inválido");
            //         quebra;
            //
            // Console.ReadKey();
        }
    }
}
