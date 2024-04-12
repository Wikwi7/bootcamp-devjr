
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6_Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {     
        	Console.WriteLine("Números primos de 1 a 100:");

        	// Loop for para iterar de 1 a 100
        	for (int numero = 2; numero <= 100; numero++)
        	{
            		bool ehPrimo = true;

            		// Verifica se o número é primo
            		for (int i = 2; i <= numero/2 ; i++)
            		{
               			 if (numero % i == 0)
                		{
                    			ehPrimo = false;
                    			break;
                		}
            		}

            		// Se o número for primo, imprime-o na tela
            		if (ehPrimo)
            		{
                		Console.WriteLine(numero);
            		}
        	}         
         }
    }
}