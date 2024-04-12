using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploSwitchCase2
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int mes;
                Console.WriteLine("Digite o número do mês de 1 a 12!): ");
                mes = Convert.ToInt32(Console.ReadLine());

                switch (mes)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        Console.WriteLine("Este mês tem 31 dias.");
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        Console.WriteLine("Este mês tem 30 dias.");
                        break;
                    case 2:
                        Console.WriteLine("Este mês tem 28 dias ou 29, se o ano for bissexto.");
                        break;
                    default:
                        Console.WriteLine("Nome de mês inválido.");
                        break;
                }
            }
    }
}
