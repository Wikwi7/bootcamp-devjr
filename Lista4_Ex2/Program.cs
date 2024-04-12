using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista4_Ex4
{
    internal class Program
    {
        static void Main(string[]args)
        {
            char ch;
            Console.WriteLine("Digite um unico caracter para determinação do tipo de letra que ele é:");
            ch = Convert.ToChar(Console.ReadLine());

            switch (ch)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("O carater" + ch + " é uma vogal!");
                    break;
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    Console.WriteLine("O caracter " + ch + " é uma vogal maiuscula!");
                    break;
                case 'b':
                case 'c':
                case 'd':
                case 'f':
                case 'g':
                case 'h':
                case 'j':
                case 'k':
                case 'l':
                case 'm':
                case 'n':
                case 'p':
                case 'r':
                case 's':
                case 't':
                case 'v':
                case 'x':
                case 'z':
                    Console.WriteLine("O caracter " + ch + " é uma consoante minuscula!");
                    break;
                case 'B':
                case 'C':
                case 'D':
                case 'F':
                case 'G':
                case 'H':
                case 'J':
                case 'K':
                case 'L':
                case 'M':
                case 'N':
                case 'P':
                case 'R':
                case 'S':
                case 'T':
                case 'V':
                case 'X':
                case 'Z':
                    Console.WriteLine("O caratcetr " + ch + " é uma consoante maiuscula!");
                    break;
                default:
                    Console.WriteLine("O caracter " + ch + " não é uma letra!");
                    break;
            }
        }
    }
}
    