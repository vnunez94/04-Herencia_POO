namespace Figuras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circulo miCírculo = new Circulo
            {
                Color = "rojo",
                Radio = 5.1
            };

            Cuadrado miCuadrado = new Cuadrado()
            {
                Color = "verde",
                Lado = 4.3
            };

            Console.WriteLine($"Área del círculo: {miCírculo.CalcularArea()}");
            miCírculo.Dibujar();
            Console.WriteLine();

            Console.WriteLine($"Área del cuadrado: {miCuadrado.CalcularArea()}");
            miCuadrado.Dibujar();
        }
    }
}