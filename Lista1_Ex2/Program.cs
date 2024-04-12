using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1_Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float tC, tF;
            Console.WriteLine("Forneça a temperatura em Farenheit: ");
            tF = Convert.ToSingle(Console.ReadLine());

            tC = (tF - 32)/1.8f;

            Console.WriteLine("A temperatura na escala Celsius correspondente a " + tF + "°F é " + tC + "°C.");
        }
    }
}
