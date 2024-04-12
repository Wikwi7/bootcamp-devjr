using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploSwitchCase1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia;
            Console.WriteLine("Digite um número de 1 a 7 para ver o dia da semana correspondente:");
            dia = Convert.ToInt32(Console.ReadLine());

            switch (dia)
            {
                case 1:
                    Console.WriteLine("Você escolheu DOMINGO.");
                    break;
                case 2:
                    Console.WriteLine("Você escolheu SEGUNDA-FEIRA.");
                    break; 
                case 3:
                    Console.WriteLine("Você escolheu TERÇA-FEIRA.");
                    break; 
                case 4:
                    Console.WriteLine("Você escolheu QUARTA-FEIRA.");
                    break; 
                case 5:
                    Console.WriteLine("Você escolheu QUINTA-FEIRA.");
                    break; 
                case 6:
                    Console.WriteLine("Você escolheu SEXTA-FEIRA.");
                    break; 
                case 7:
                    Console.WriteLine("Você escolheu SÁBADO.");
                    break;
                default:
                    Console.WriteLine("Valor inválido.");
                    break;
            }
        }
    }
}
