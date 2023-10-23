using clase_abstracta;

namespace Metodo_Extension1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuadrado c = new Cuadrado(5);
            Console.WriteLine("El area es :" + c.CalcularArea());
            Console.WriteLine("El Perimetro es :" + c.CalcularPerimetro());
            c.dibujar();
            Console.WriteLine();


        }
    }

    public static class Extension
    {

        public static double CalcularPerimetro(this Cuadrado c)
        {
            return c.getLado() * 4;
        }

        public static void dibujar(this Cuadrado c)
        {
            Console.WriteLine("\nDibujando Cuadrado ");
            for (int i = 0; i < c.getLado(); i++)
            {
                for (int j = 0; j < c.getLado(); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }


    }

}