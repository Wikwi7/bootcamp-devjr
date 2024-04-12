using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_Ex4
{
    internal class Program
    {
        static void Main(String[] args)
        {
            int ano;
            Console.WriteLine("Entre com um ano para verificar se é ou não bissexto:");
            ano = Convert.ToInt32(Console.ReadLine());

            if (ano % 400 == 0 || (ano % 4 == 0 && ano % 100 !=0))
            {
                Console.WriteLine("O ano " + ano + " é bissexto!");
            }
            else
            {
                Console.WriteLine("O ano " + ano + " Não é bissexto!");
            }
        }
    }
}