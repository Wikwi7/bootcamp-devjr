using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float baseRet, alturaRet, area;
            Console.WriteLine("Forneça a base do retângulo: ");
            baseRet = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Forneça a altura do retângulo: ");
            alturaRet = Convert.ToSingle(Console.ReadLine());

            area = baseRet * alturaRet;

            Console.WriteLine("A área do retângulo de base " + baseRet + " e altura " + alturaRet + " vale: " + area+".");
        }
    }
}
