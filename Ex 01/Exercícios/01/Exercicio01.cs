using FirstAula.Exercícios._01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAula.Exercícios
{
    class Exercicio01
    {
        private static void Main(string[] args)
        {
            BombaAgricola bomba = new BombaAgricola();
            var tempo = 0;

            Console.Write("Digite o volume inicial do frasco em (em ml) ");
            bomba.VolumeInicial = int.Parse(Console.ReadLine());
            while (bomba.VolumeInicial <= 0)
            {
                Console.Write("Digite o volume inicial do frasco que seja maior que 0");
                bomba.VolumeInicial = int.Parse(Console.ReadLine());
            }
            Console.Write("Digite a vazão da bomba (em ml/s) ");
            bomba.Vazao = int.Parse(Console.ReadLine());
            while (bomba.Vazao <= 0)
            {
                Console.Write("Digite a vazão da bomba que seja maior que 0 ");
                bomba.Vazao = int.Parse(Console.ReadLine());
            }
            Console.Write("Digite o tempo em que elá ficará aberta em segundos ");
            tempo = int.Parse(Console.ReadLine());

            var resultado = bomba.CalculoVazao(tempo);
            if (resultado < 0)
            {
                Console.Write("náo eh possivel");
            }
            else
            {
                Console.Write("Resultado " + resultado + " segundos.");
            }
            Console.Read();
        }
    }
}
