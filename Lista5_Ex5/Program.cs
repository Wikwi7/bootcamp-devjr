using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista5_Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
        	Console.Write("Digite uma palavra: ");
        	string palavra = Console.ReadLine().ToLower(); // Converte a palavra para minúsculas para facilitar a comparação
        	int contadorVogais = 0;
        	int indice = 0;

        	while (indice < palavra.Length)
        	{
            		char caractere = palavra[indice];

            		// Verifica se o caractere atual é uma vogal
            		if (caractere == 'a' || caractere == 'e' || caractere == 'i' || caractere == 'o' || caractere == 'u')
            		{
                		contadorVogais++;
            		}
	            	indice++;
        	}
        	Console.WriteLine("O número de vogais na palavra \"" + palavra + "\" é: " + contadorVogais);
         }
    }
}
