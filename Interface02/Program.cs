namespace InterfaceExplicita
{

    public interface IAutomovil
    {
        void Acelerar();
        void Frenar();
        void Despegar();
    }
    public interface IAvion
    {
        void Despegar();
    }

    public class Vehiculo : IAutomovil, IAvion
    {
        public void Acelerar()
        {
            Console.WriteLine("Acelerando el vehículo");
        }
        public void Frenar()
        {
            Console.WriteLine("Frenando el vehículo");
        }
        // Implementación explícita del método "Despegar" de la interface IAutomovil
        void IAutomovil.Despegar()
        {
            Console.WriteLine("Despegando el vehículo como automóvil");
        }
        // Implementación explícita del método "Despegar" de la interface IAvion
        void IAvion.Despegar()
        {
            Console.WriteLine("Despegando el vehículo como avión");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Vehiculo vehiculo = new Vehiculo();
            vehiculo.Acelerar();
            vehiculo.Frenar();
            //vehiculo.Despegar(); // Error de compilación
            // Invocación del método "Despegar" de la interface IAutomovil
            ((IAutomovil)vehiculo).Despegar();
            // Invocación del método "Despegar" de la interface IAvion
            ((IAvion)vehiculo).Despegar();

        }
    }

}