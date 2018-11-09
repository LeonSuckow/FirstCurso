using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_05
{
    class Ex_05
    {
        public static void Main(string [] args)
        {
            double distanciaDardo, maiorDistancia = 0;
            for (int i = 1; i < 4; i++)
            {
                Console.Write("Digite o valor da distancia do " + i + "º dardo ");
                distanciaDardo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (maiorDistancia < distanciaDardo)
                {
                    maiorDistancia = distanciaDardo;
                }
            }
            Console.Write("Maior distancia é " + maiorDistancia.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
