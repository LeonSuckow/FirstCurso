using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_08
{
    class Ex_08
    {
        static void Main(string[] args)
        {
            int val1, val2, val3;

            Console.Write("Digite o 1º valor que deseja ");
            val1 = int.Parse(Console.ReadLine());       
            Console.Write("Digite o 2º valor que deseja ");
            val2 = int.Parse(Console.ReadLine());       
            Console.Write("Digite o 3º valor que deseja ");
            val3 = int.Parse(Console.ReadLine());

            for (int i = val2; i <= val3; i++)
            {
                if (i % val1 == 0)
                {
                    Console.Write("- " +i.ToString());
                }
                else
                {
                    Console.Write("");
                }
            }
            Console.ReadLine();
        }
    }
}
