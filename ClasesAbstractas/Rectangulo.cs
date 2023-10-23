namespace clase_abstracta
{
    public class Rectangulo : Figura
    {
        protected double lado1; //base
        protected double lado2; //altura

        public Rectangulo(double lado1, double lado2)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
        }     
     

        public override double CalcularArea()
        {

            return lado1 * lado2;
        }
    }
}