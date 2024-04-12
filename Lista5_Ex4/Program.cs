using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista5_Ex4
{
    internal class Program
    {
        static void Main(string[]args)
        {
            long fat = 1, n;
            Console.WriteLine("Entre com um número inteiro positivo para o cálculo do fatorial:");
            n = long.Parse(Console.ReadLine());

            if(n<0){
                Console.WriteLine("A função fatorial não está definida para inteiros negativos.");
                return;
            }
            Console.Write("O fatorial de " + n + " vale:");
            while(n>1){
                fat*= n;
                n--;
            }
            Console.WriteLine(fat);
        }
    }
}
