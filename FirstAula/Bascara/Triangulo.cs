using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAula
{
    public class Triangulo
    {
        public double a, b, c;

        public double CalculaArea()
        {
            var p = (a + b + c) / 2.0;
            var area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return area;
        }
    }
}
