using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

//14) Ler um valor e escrever a mensagem É MAIOR QUE 10! se o valor lido for maior que 10, caso
//contrário escrever NÃO É MAIOR QUE 10!

namespace FaccatCsharp
{
    internal class Exercicio14
    {
        public static void Main(string[] args)
        {
            Console.Write("Por digite um número: ");
            double numero = Convert.ToDouble(Console.ReadLine());

            if (numero > 10)
            {
                Console.WriteLine("ESSE NÚMERO É MAIOR QUE 10!");
            }
            else
            {
                Console.WriteLine("ESSE NÚMERO NÃO É MAIOR QUE 10!");
            }
        }
    }
}
