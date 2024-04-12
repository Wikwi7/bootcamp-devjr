using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1_Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float cat1, cat2, hip;
            Console.WriteLine("Entre com o valor do cateto de um triângulo retângulo:");
            cat1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Entre com o valor do outro cateto do triângulo:");
            cat2 = Convert.ToSingle(Console.ReadLine());

            //Aplicando Pitágoras para o cálculo da hipotenusa
            hip = (float)Math.Sqrt(Math.Pow(cat1, 2) + Math.Pow(cat2, 2));
            Console.WriteLine("A hipotenusa vale: " + hip);
        }
    }
}
