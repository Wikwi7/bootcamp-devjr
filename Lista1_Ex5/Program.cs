using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1_Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float raio, perimetro, area;

            Console.WriteLine("Entre com o raio do círculo para o cálculo da área e do perímetro:");
            raio = Convert.ToSingle(Console.ReadLine());

            //Cálculo da área e do perímetro
            perimetro = (float)Math.PI * 2 * raio;
            area = (float)Math.PI * (float)Math.Pow(raio, 2);
            Console.WriteLine("A área do círculo de raio " + raio + " vale " + Math.Round(area,2));
            Console.WriteLine("O perímetro do círculo de raio " + raio + " vale " + Math.Round(perimetro, 2));
        }
    }
}
