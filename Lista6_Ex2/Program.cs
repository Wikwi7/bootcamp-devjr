using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6_Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        	int soma = 0;

	for (int i = 1; i <= 100; i++)
        	{
            		soma += i;
        	}

        	Console.WriteLine("A soma dos primeiros 100 números naturais é: " + soma);
         }
    }
}