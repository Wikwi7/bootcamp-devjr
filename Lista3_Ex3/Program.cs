using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_Ex3
{
    internal class Program
    {
    static void Main(string[]args)
    {
        float a1, a2, a3;
        //Entrada dos dados
        Console.WriteLine("Entre com o primeiro ângulo interno do triangulo:");
        a1=Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Entre com o segundo ângulo interno do triangulo:");
        a2=Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Entre com o terceiro ângulo interno do triangulo:");
        a3=Convert.ToSingle(Console.ReadLine());
    
    
        //Processamento e saída
        if (a1+a2+a3==180)
        {
            //Podem ser os ângulos internos de um triangulo
            if (a1 == 90 || a2 == 90 || a3 ==90)
            {
                Console.WriteLine("O triangulo com os ângulos internos:" + a1 + ", "+ a2 + " e " + a3 +" é um triangulo RETÂNGULO!");
            }
            else if (a1 > 90 || a2 > 90 || a3 > 90)
            {
                Console.WriteLine("O triangulo com os ângulos internos: "+ a1 +", "+ a2 +", "+ a3 +" é um triangulo OBTUSÂNGULO!");
            }
            else 
            {
                Console.WriteLine("O triangulo com os ângulos internos: "+ a1 +", "+ a2 +", "+ a3 +" é um triangulo ACUTÂNGULO!");
            }
        
        }
        else
        {
            Console.WriteLine("Os valores: "+ a1 +", "+ a2 +", "+ a3 +" não pode ser os ãngulos internos de um triangulo, pois a soma entre eles não é igual a 180°.");
        }
    }
    }
}

        