using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAula.Exercícios._01
{
    public class BombaAgricola
    {
        public int VolumeInicial { get; set; }
        public int Vazao { get; set; }

        public int CalculoVazao(int tempo)
        {
            return VolumeInicial - (Vazao * tempo);
        }
    }
}
