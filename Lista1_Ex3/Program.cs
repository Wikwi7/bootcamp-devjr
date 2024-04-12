using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1_Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float valor, desc, valorDesc;
            Console.WriteLine("Forneça o valor da compra: ");
            valor = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Forneça o percentual de desconto: ");
            desc = Convert.ToSingle(Console.ReadLine());

            valorDesc = valor - desc*valor/100;

            Console.WriteLine("O valor da compra com desconto é " + valorDesc + ".");
        }
    }
}
