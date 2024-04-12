using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6_Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {     
	// Inicializamos os dois primeiros termos da sequência de Fibonacci
        	int termoAtual = 0;
        	int proximoTermo = 1;

        	Console.WriteLine("Os primeiros 10 termos da sequência de Fibonacci são:");

        	// Loop for para calcular e imprimir os termos da sequência
        	for (int i = 1; i <= 10; i++)
        	{
            		Console.WriteLine(termoAtual);

            		// Calculamos o próximo termo da sequência somando os dois termos anteriores
            		int novoTermo = termoAtual + proximoTermo;
            		termoAtual = proximoTermo;
           		proximoTermo = novoTermo;
        	}
         }
    }
}