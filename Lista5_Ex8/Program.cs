using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista5_Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
        	Console.Write("Digite uma palavra: ");
        	string palavra = Console.ReadLine().ToLower(); // Converte a palavra para minúsculas para facilitar a comparação
        	int inicio = 0;
        	int fim = palavra.Length - 1;
        	bool palindromo = true;
        	while (inicio < fim)
        	{
            		if (palavra[inicio] != palavra[fim])
            		{
                		palindromo = false;
                		break; // Sai do loop se encontrar caracteres diferentes
            		}
            		inicio++;
            		fim--;
        	}
	if (palindromo)
        	{
            		Console.WriteLine("A palavra \"" + palavra + "\" é um palíndromo.");
        	}
        	else
        	{
            		Console.WriteLine("A palavra \"" + palavra + "\" não é um palíndromo.");
        	}
         }
    }
}