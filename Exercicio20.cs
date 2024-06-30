using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

//20) Ler dois valores (considere que não serão lidos valores iguais) e escrevê-los em ordem crescente.

namespace FaccatCsharp
{
    internal class Exercicio20
    {
        public static void Main(string[] args)
        {
            Console.Write("Por favor, igite o primeiro número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Por vaor, digite o segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            if (numero1 < numero2)
            {
                Console.WriteLine("Os números em ordem crescente são: " + numero1 + ", " + numero2);
            }
            else
            {
                Console.WriteLine("Os números em ordem crescente são: " + numero2 + ", " + numero1);
            }
        }
    }
}
