using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista5_Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
         	Console.Write("Digite um número inteiro: ");
        	int numero = int.Parse(Console.ReadLine());    

        	Console.WriteLine("Os divisores de " + numero + " são:");
	Console.WriteLine("1");
	int divisor = 2; // Iniciando de 2, já que todo número é divisível por 1
        	while (divisor <= numero / 2)
        	{
            		if (numero % divisor == 0)
            		{
                		Console.WriteLine(divisor);
            		}
            		divisor++;
        	}
        	// Por fim, exibimos o próprio número, já que todo número é divisível por ele mesmo
        	Console.WriteLine(numero);         
         }
    }
}