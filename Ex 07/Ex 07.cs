using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_07
{
    class Ex_07
    {
        static void Main(string[] args)
        {
            int valor = 1, valorQuad, count = 1;

            while (valor > 0)
            {
                Console.Write("Digite o "+count+"º valor que deseja saber o ² ou 0 para parar ");
                valor = int.Parse(Console.ReadLine());
                if (valor > 0)
                {
                    valorQuad = valor * valor;
                    Console.WriteLine("O quadrado de " +valor+ " é " +valorQuad);
                }
                else
                {
                    Console.Write("Sistema parou");
                    break;
                }
                count++;
            }
            Console.ReadLine();
        }
    }
}
