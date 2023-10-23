namespace clase_abstracta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figura[] figuras = new Figura[3];
            figuras[0] = new Circulo(5);
            figuras[1] = new Rectangulo(5, 4);
            figuras[2] = new Cuadrado(5);
            // liskov





            foreach (Figura figura in figuras)
            {
                System.Console.WriteLine("Tipo: " + figura.GetType().Name);
                System.Console.WriteLine("Area: " + figura.CalcularArea());
                System.Console.WriteLine();
            }

             
        }
    }
}