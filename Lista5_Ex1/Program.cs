using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploWhile1
{
    internal class Program
    {
        static void Main(string[]args)
        {
            int n = 1;
            while (n <= 20)
            {
                if (n % 2 ==0)
                {
                    Console.WriteLine(n);
                }
                n++;
            }
        }
    }
}