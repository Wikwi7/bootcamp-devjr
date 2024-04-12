using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPascoa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, ano, a, b, c, d, e, f, g, h, i, k, l, m;

            Console.WriteLine("Forneça o ano para o cálculo da data da Páscoa:");
            ano = Convert.ToInt32(Console.ReadLine());

            a = ano % 19;
            b = ano / 100;
            c = ano % 100;
            d = b / 4;
            e = b % 4;
            f = (b + 8) / 25;
            g = (b - f + 1) / 3;
            h = (19 * a + b - d - g + 15) % 30;
            i = c / 4;
            k = c % 4;
            l = (32 + 2 * e + 2 * i - h - k) % 7;
            m = (a + 11 * h + 22 * l) / 451;
            mes = (h + l - 7 * m + 114) / 31;
            dia = 1 + (h + l - 7 * m + 114) % 31;
            Console.WriteLine("No ano fornecido a data da Páscoa é: " + dia + "/" + mes + "/" + ano + ".");
        }
    }
}
