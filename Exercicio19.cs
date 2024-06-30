using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

//19) Ler dois valores (considere que não serão lidos valores iguais) e escrever o maior deles.

namespace FaccatCsharp
{
    internal class Exercicio19
    {
        public static void Main(string[] args)
        {
            Console.Write("Por favor, digite o primeiro número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Por favor, digite o segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine("O maior número é: " + numero1);
            }
            else
            {
                Console.WriteLine("O maior número é: " + numero2);
            }
        }
    }
}
