/*
Vamos a desarrollar un caso práctico relacionado con figuras geométricas.
Crearemos una clase abstracta llamada Figura.
Definiremos una interfaz IDibujable que permitirá dibujar la figura.
Crearemos clases concretas que hereden de Figura e implementen la interfaz IDibujable.
 */

namespace Figuras
{
    public abstract class Figura
    {
        protected string color="sin color";

        // Método abstracto para calcular el área de la figura
        public abstract double CalcularArea();

        // Propiedad para el color de la figura
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        //getter y setter
        public string GetColor()
        {
            return color;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }
    }

}
