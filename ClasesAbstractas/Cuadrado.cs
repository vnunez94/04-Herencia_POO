using System;

namespace clase_abstracta
{
    public class Cuadrado:Rectangulo
    {
        public Cuadrado(double lado):base(lado,lado)
        {
        }

        public double getLado()
        {
            return lado1;
        }

    }
}
