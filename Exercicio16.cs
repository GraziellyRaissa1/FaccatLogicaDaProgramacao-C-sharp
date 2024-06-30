using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*16) As maçãs custam R$ 1,30 cada se forem compradas menos de uma dúzia, e R$ 1,00 se forem
compradas pelo menos 12. Escreva um programa que leia o número de maçãs compradas, calcule e
escreva o custo total da compra.*/

namespace FaccatCsharp
{
    internal class Exercicio16
    {
        public static void Main(string[] args)
        {
            Console.Write("Por favor, digite o número de maçãs compradas: ");
            int quantidadeMacas = Convert.ToInt32(Console.ReadLine());
            double precoMacas;

            if (quantidadeMacas < 12)
            {
                precoMacas = 1.30;
            }
            else
            {
                precoMacas = 1.00;
            }

            double custoTotal = quantidadeMacas * precoMacas;
            Console.WriteLine("O Valor total das maçasé: R$ " + custoTotal.ToString("F2"));
        }
    }
}
}
