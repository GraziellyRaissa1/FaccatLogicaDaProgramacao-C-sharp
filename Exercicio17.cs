using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

/*17) Ler as notas da 1a. e 2a. avaliações de um aluno. Calcular a média aritmética simples e escrever
uma mensagem que diga se o aluno foi ou não aprovado (considerar que nota igual ou maior que 6 o
aluno é aprovado). Escrever também a média calculada.*/

namespace FaccatCsharp
{
    internal class Exercicio17
    {
        public static void Main(string[] args)
        {
            Console.Write("Informe a nota da primeira avaliação: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a nota da segunda avaliação: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            double media = (nota1 + nota2) / 2;

            if (media >= 6)
            {
                Console.WriteLine("Aluno aprovado com média: " + media.ToString("F1"));
            }
            else
            {
                Console.WriteLine("Aluno reprovado com média: " + media.ToString("F1"));
            }
        }
    }
}
