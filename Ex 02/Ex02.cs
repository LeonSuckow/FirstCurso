using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_02
{
    class Ex02
    {
        public static void Main (string[] args)
        {

            Console.Write("Digite o número de notas ");
            var quantidadeNotas = int.Parse(Console.ReadLine());
            double notaAtual = 0;
            double totalNota = 0;
            for (int i = 1; i <= quantidadeNotas; i++)
            {
                Console.Write("Digite a " + i + "ª nota ");
                notaAtual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                totalNota = totalNota + notaAtual;
            }


            if (totalNota > 60)
                Console.Write("Total : " + totalNota.ToString("F2", CultureInfo.InvariantCulture));
            else
                Console.Write("Total : " + totalNota.ToString("F2", CultureInfo.InvariantCulture) + ". Você ficou dependencia");
            Console.ReadLine();
        }
    }
}
