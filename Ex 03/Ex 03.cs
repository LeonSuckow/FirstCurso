using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_03
{
    class Ex_03
    {
        public static void Main (string[] args)
        {
            var alturaFoto = 0;
            var larguraFoto = 0;
            var alturaQuadro = 0;
            var larguraQuadro = 0;

            Console.Write("Digite a largura da foto ");
            larguraFoto = int.Parse(Console.ReadLine());

            Console.Write("Digite a altura da foto ");
            alturaFoto = int.Parse(Console.ReadLine());

            Console.Write("Digite a largura do quadro ");
            larguraQuadro = int.Parse(Console.ReadLine());

            Console.Write("Digite a altura do quadro ");
            alturaQuadro = int.Parse(Console.ReadLine());

            if (alturaFoto <= alturaQuadro && larguraFoto <= larguraQuadro || larguraFoto <= alturaQuadro && alturaFoto <= larguraQuadro)
                Console.WriteLine("Sim");
            else
                Console.WriteLine("Não");
            Console.ReadLine();
        }
    }
}
