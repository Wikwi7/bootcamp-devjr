using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6_Ex5
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

        	// Variável para contar o número de divisores
        	int divisores = 0;

        	// Loop for para verificar se o número é primo
        	for (int i = 2; i <= numero / 2; i++)
        	{
            		if (numero % i == 0)
            		{
                		divisores++;
                		break; // Interrompe o loop se encontrar um divisor
            		}
        	}

        	// Verifica se o número é primo
        	if (divisores == 0)
        	{
            		Console.WriteLine(numero + " é um número primo.");
        	}
        	else
        	{
            		Console.WriteLine(numero + " não é um número primo.");
        	}
         }
    }
}