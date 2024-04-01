using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero de 1 a 7 ( PARA SABER O DIA CORRESPONDENTE )");
            int num1 = int.Parse(Console.ReadLine());
            switch (num1)
            {
                case 1:
                    Console.WriteLine(" 1 - DOMINGO ");
                    break;

                case 2:
                    Console.WriteLine(" 2 - SEGUNDA-FEIRA ");
                    break;

                case 3:
                    Console.WriteLine(" 3 - TERÇA-FEIRA ");
                    break;

                case 4:
                    Console.WriteLine(" 4 -QUARTA-FEIRA ");
                    break;

                case 5:
                    Console.WriteLine(" 5 - QUINTA-FEIRA ");
                    break;
                case 6:
                    Console.WriteLine(" 6 - SEXTA-FEIRA ");
                    break;

                case 7:
                    Console.WriteLine(" 7 - SABADO ");
                    break;

                default:

                    Console.WriteLine(" DIA INVÁLIDO ");
                    break;


            }
            Console.ReadKey();
        }
    }
}
