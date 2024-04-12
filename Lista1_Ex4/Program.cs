using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1_Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, num3, media;
            Console.WriteLine("Forneça o primeiro valor: ");
            num1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Forneça o segundo valor: ");
            num2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Forneça o terceiro valor: ");
            num3 = Convert.ToSingle(Console.ReadLine());

            media = (num1+num2+num3)/ 3;

            Console.WriteLine("A média dos três valores fornecidos é " + media + ".");

        }
    }
}
