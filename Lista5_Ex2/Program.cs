using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista5_Ex2
{
    internal class Program
    {
        static void Main(string[]args)
        {
            int n, soma = 0;
            while(true)
            {
                Console.WriteLine("Encontre com um numero inteiro positivo, para o calculo da soma ou um valor negativo, para terminar o programa");
                n=int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    break;
                }
                soma = soma +n;
            }
            if (soma >0)
            {
                Console.WriteLine("A soma dos numeros fornecidos é: " + soma);
            }
            else
            {
                Console.WriteLine("Não foram fornecidos quaisquer números inteiros positivos");
            }
        }
    }
}