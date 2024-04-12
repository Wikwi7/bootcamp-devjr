using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista4_Ex4
{
    internal class Program
    {
        static void Main(String[] aergs)
        {
            int num;
            Console.WriteLine("Digite um numero inteiro para determinar se é par ou impar:");
            num = Convert.ToInt32(Console.ReadLine());

            switch(num % 2)
            {
                case 0:
                    Console.WriteLine("O número " + num + " é par.");
                    break;
                case 1:
                    Console.WriteLine("O numero " + num + " é impar.");
                    break;

            }
        }
    }
}