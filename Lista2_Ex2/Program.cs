using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lst2_Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, delta, x1, x2;
            //Entrada dos dados
            Console.WriteLine("Forneça o valor do coeficiente a, que acompanha o termo quadrático:");
            a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Forneça o valor do coeficiente b, que acompanha o termo linear:");
            b = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Forneça o valor do coeficiente c, que é o coeficiente independente:");
            c = Convert.ToSingle(Console.ReadLine());
            //Processamento
            delta = (float)Math.Pow(b, 2) - 4 * a * c;
            if (delta > 0) {
                x1 = (-b + (float)Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - (float)Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("O delta é positivo e as raízes da função são: " + x1 + " e " + x2 + ".");
            }           
            else if(delta == 0) {
                x1 = (-b) / (2 * a);
                Console.WriteLine("O delta é nulo e a única raíz da função é: " + x1 + ".");
            }
            else
            {
                Console.WriteLine("O delta é negativo é esta função quadrática não tem raízes reais.");
            }
        }
    }
}