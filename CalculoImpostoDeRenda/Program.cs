//Codigo da Tarefa 1
using System;

namespace CalculoImpostoRenda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quanto se ganha Otariuuuuu?:");
            double renda = Convert.ToDouble(Console.ReadLine());

            double impostoSimplificado = CalcularImpostoSimplificado(renda);
            double impostoCompleto = CalcularImpostoCompleto(renda);
           
            Console.WriteLine($"Salário bruto: R$ {renda:F2}");
            Console.WriteLine($"Imposto de renda (Simplificado): R$ {impostoSimplificado:F2}");
            Console.WriteLine($"Imposto de renda (Completo): R$ {impostoCompleto:F2}");
           
        }

        static double CalcularImpostoSimplificado(double renda)
        {
            // Exemplo de cálculo de imposto simplificado:
            // Aplicamos uma taxa fixa de 15% sobre a renda.
            return 0.15 * renda;
        }

        static double CalcularImpostoCompleto(double renda)
        {
            // Exemplo de cálculo de imposto completo:
            // Se a renda for menor que R$ 1.903,98, não há imposto.
            // Caso contrário, aplicamos uma tabela progressiva.
            if (renda < 1903.98)
            {
                return 0;
            }
            else if (renda < 2826.65)
            {
                return (renda - 1903.98) * 0.075;
            }
            else if (renda < 3751.05)
            {
                return (renda - 2826.65) * 0.15 + 142.80;
            }
            else if (renda < 4664.68)
            {
                return (renda - 3751.05) * 0.225 + 354.80;
            }
            else
            {
                return (renda - 4664.68) * 0.275 + 636.13;
            }
        }
    }
}
