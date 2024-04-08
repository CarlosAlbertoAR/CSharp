using System;

namespace TrianguloClass
{
    class Triangulo
    {
        public double LadoA;    
        public double LadoB;
        public double LadoC;
        public double Area;

        public void CalcularArea()
        {
            double p = (LadoA + LadoB + LadoC) / 2.0;
            Area = Math.Sqrt(p * (p - LadoA) * (p - LadoB) * (p - LadoC));
        }
    }
}
