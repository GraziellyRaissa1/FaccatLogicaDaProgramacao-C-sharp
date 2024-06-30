using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

//15) Ler um valor e escrever se é positivo ou negativo (considere o valor zero como positivo).

namespace FaccatCsharp
{
    internal class Exercicio15
    {
        public static void Main(string[] args)
        {
            Console.Write("Por favor, digite um numero: ");
            double numero = Convert.ToDouble(Console.ReadLine());

            if (numero >= 0)
            {
                Console.WriteLine("O número informado é positivo.");
            }
            else
            {
                Console.WriteLine("O número informado é negativo.");
            }
        }
    }
}
