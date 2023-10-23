using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public class Circulo : Figura, IDibujable
    {
        public double radio;

        //propiedades
        public double Radio
        {
            get { return radio; }
            set { radio = value; }
        }

        public override double CalcularArea()
        {
            return Math.PI * Radio * Radio;
        }

        public void Dibujar()
        {
            Console.WriteLine($"Dibujando un círculo de color {Color} y radio {Radio}.");
        }
    }



}
