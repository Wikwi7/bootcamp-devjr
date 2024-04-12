using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6_Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {     
        	Console.Write("Digite um número inteiro positivo: ");
        	int numero = int.Parse(Console.ReadLine());

        	// Verifica se o número é positivo
        	if (numero <= 0)
        	{
            		Console.WriteLine("O número inserido não é válido. Por favor, insira um número inteiro positivo.");
            		return; // Encerra o programa
        	}

        	Console.WriteLine("Os divisores de " + numero + " são:");

        	// Imprime o divisor 1
        	Console.WriteLine(1);

        	// Loop for para encontrar e imprimir os divisores do número (exceto ele mesmo)
        	for (int i = 2; i <= numero / 2; i++)
        	{
            		if (numero % i == 0)
            		{
                		Console.WriteLine(i);
            		}
        	}

        	// Imprime o próprio número (caso seja diferente de 1)
        	if (numero != 1)
        	{
            		Console.WriteLine(numero);
        	}
         }
    }
}