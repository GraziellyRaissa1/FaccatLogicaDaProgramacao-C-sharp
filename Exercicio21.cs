using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

/*21) Ler a hora de início e a hora de fim de um jogo de Xadrez (considere apenas horas inteiras, sem os
minutos) e calcule a duração do jogo em horas, sabendo-se que o tempo máximo de duração do jogo é
de 24 horas e que o jogo pode iniciar em um dia e terminar no dia seguinte.*/ 


namespace FaccatCsharp
{
    internal class Exercicio21
    {
        public static void Main(string[] args)
        {
            Console.Write("Por favor, digite a hora de início do jogo: ");

            int horaInicioJogo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Por favor, digite a hora de fim do jogo: ");
            int horaFimJogo = Convert.ToInt32(Console.ReadLine());

            int duracaoDoJogo;

            if (horaFimJogo >= horaInicioJogo)
            {
                duracaoDoJogo = horaFimJogo - horaInicioJogo;
            }
            else
            {
                duracaoDoJogo = (24 - horaInicioJogo) + horaFimJogo;
            }

            Console.WriteLine("A duração do jogo De xadrez é: " + duracaoDoJogo + " horas.");
        }
    }
}
