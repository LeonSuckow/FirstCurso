using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_04
{
    class Ex_04
    {
        public static void Main(string[] args)
        {
            double glicose;

            Console.Write("Digite a quantidade de glicose ");
            glicose = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (glicose <= 100)
            {
                Console.Write("Normal");
            }
            else if (glicose > 100 && glicose <= 140.0)
            {
                Console.Write("Elevado");
            }
            else if (glicose > 140)
            {
                Console.Write("Diabetes");
            }
            Console.ReadLine();
        }
    }
}
