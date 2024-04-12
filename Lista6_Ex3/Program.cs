using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6_Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
        	// Solicita ao usuário que insira um número inteiro positivo
        	Console.Write("Digite um número inteiro positivo: ");
        	int numero = int.Parse(Console.ReadLine());

        	// Verifica se o número inserido é positivo
        	if (numero > 0)
        	{
            		Console.WriteLine("Tabuada do número " + numero + ":");
            		// Loop for para calcular e imprimir a tabuada
            		for (int i = 1; i <= 10; i++)
            		{
                		Console.WriteLine(numero + " x " + i + " = " + (numero * i));
            		}
        	}
        	else
        	{
            		Console.WriteLine("O número inserido não é válido. Por favor, insira um número inteiro positivo.");
        	}
         }
    }
}