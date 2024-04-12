using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float peso, altura, imc;
            //Entrada de dados
            Console.WriteLine("Qual é o seu peso em kg?");
            peso = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Qual é a sua altura em m?");
            altura = Convert.ToSingle(Console.ReadLine());
            //Processamento
            imc = peso / (float)Math.Pow(altura, 2);
            Console.WriteLine("Seu imc vale: "+ imc + " e você está:");
            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso normal.");
            }
            else if (imc < 25)
            {
                Console.WriteLine("Peso normal.");
            }
            else if(imc < 30)
            {
                Console.WriteLine("Excesso de peso.");
            }
            else if(imc < 35)
            {
                Console.WriteLine("Obesidade classe I.");
            }
            else if (imc < 40)
            {
                Console.WriteLine("Obesidade classe II.");
            }
            else
            {
                Console.WriteLine("Obesidade classe III.");
            }
        }
    }
}
