using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*13) Faça um algoritmo que leia três notas de um aluno, calcule e escreva a média final deste aluno.
Considerar que a média é ponderada e que o peso das notas é 2, 3 e 5. Fórmula para o cálculo da média
final é:
 n1 * 2 + n2 * 3 + n3 * 5
 mediafinal = -----------------------------------
 10*/

namespace FaccatCsharp
{
    internal class Exercicio13
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite a primeira nota: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            double nota3 = Convert.ToDouble(Console.ReadLine());

            double mediaFinalAluno = (nota1 * 2 + nota2 * 3 + nota3 * 5) / 10;
            Console.WriteLine("A média final é: " + mediaFinalAluno);
        }
    }
}
