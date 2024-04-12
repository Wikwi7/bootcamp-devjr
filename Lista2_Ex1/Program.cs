using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            //Entrada dos dados
            Console.WriteLine("Forneça um valor numérico inteiro:");
            num = Convert.ToInt32(Console.ReadLine());
 
           if (num%2 == 0) {
                Console.WriteLine("O número " + num + " é par.");
            }           
            else
            {
                Console.WriteLine("O número " + num + " é ímpar.");
            }
        }
    }
}