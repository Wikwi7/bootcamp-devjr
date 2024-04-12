using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista4_Ex3
{
    internal class Program
    {
        static void Main(string[]args)
        {
            float n1,n2,res;
            char op;

            Console.WriteLine("Entre com a operação desejada: (+ para adição, - para subtração, / para divisão ou * para multiplicação):");
            op=Convert.ToChar(Console.ReadLine());

            switch (op)
            {
                case '+':
                Console.WriteLine("Entre com o primeiro valor da adição:");
                n1=Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Entre com o segundo valor da adição:");
                n2=Convert.ToSingle(Console.ReadLine());
                res=n1+n2;
                Console.WriteLine(n1 + " + "+ n2 + " = "+ res);
                break;

                case '-':
                Console.WriteLine("Entre com o primeiro valor da subtração:");
                n1=Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Entre com o segundo valor da subtração:");
                n2=Convert.ToSingle(Console.ReadLine());
                res=n1-n2;
                Console.WriteLine(n1 + " - "+ n2 + " = "+ res);
                break;

                case '*':
                Console.WriteLine("Entre com o primeiro valor da multiplicação:");
                n1=Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Entre com o segundo valor da multiplicação:");
                n2=Convert.ToSingle(Console.ReadLine());
                res=n1*n2;
                Console.WriteLine(n1 + " * "+ n2 + " = "+ res);
                break;

                case '/':
                Console.WriteLine("Entre com o primeiro valor da divisão:");
                n1=Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Entre com o segundo valor da divisão:");
                n2=Convert.ToSingle(Console.ReadLine());
                if (n2 !=0)
                {
                    res=n1 / n2;
                    Console.WriteLine(n1+ " / "+ n2 + " = "+ res);

                }
                else
                {
                    Console.WriteLine("A divisão por zero não está definida na matematica!");
                }
                break;
                default:
                Console.WriteLine("Operação Invalida!");
                break;
            }
        }
    }
}