using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_06
{
    class Ex_06
    {
        static void Main(string[] args)
        {
            int num1, num2, soma = 0;

            Console.Write("Coloque o primeiro número ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Coloque o segundo número ");
            num2 = int.Parse(Console.ReadLine());
            while (num1 > num2)
            {
                Console.Write("O primeiro não pode ser menor que o segundo. Digite novamente o segundo ");
                num2 = int.Parse(Console.ReadLine());
            }

            for (int i = num1; i <= num2; i++)
            {
                if (!(i % 2 == 0))
                {
                    soma = soma + i;
                }
            }
            Console.Write("Total: " + soma);
            Console.ReadLine();
        }
    }
}
