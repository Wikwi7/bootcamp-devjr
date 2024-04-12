using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista5_Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma sequência de números (digite 0 para encerrar):");

            float soma = 0, numero, media; 
            int contador = 0; 

            while (true)
            {
                Console.Write("Digite um número: ");
                numero = float.Parse(Console.ReadLine());

                if (numero == 0)
                {
                    break; // Sai do loop se o número inserido for 0
                }

                soma += numero; // Adiciona o número à soma
                contador++; // Incrementa o contador de números
            }

            if (contador == 0)
            {
                Console.WriteLine("Nenhum número foi inserido.");
            }
            else
            {
                media = soma / contador; // Calcula a média
                Console.WriteLine("A média dos números inseridos é: " + media);
            }
         }
    }
}
