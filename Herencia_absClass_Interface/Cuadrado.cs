
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public class Cuadrado : Figura, IDibujable
    {
        public double lado;
        //propiedades
        public double Lado
        {
            get { return lado; }
            set { lado = value; }
        }

        public override double CalcularArea()
        {
            return Lado * Lado;
        }

        public void Dibujar()
        {
            Console.WriteLine($"Dibujando un cuadrado de color {Color} y lado {Lado}.");
        }
    }
}
