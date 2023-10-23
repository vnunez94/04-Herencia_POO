namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.setNombre("Animal");
            Console.WriteLine("El nombre del animal es: "+animal.getNombre());
            animal.Mover();
            Pajaro pajaro = new Pajaro();
            pajaro.setNombre("Pájaro");
            Console.WriteLine("El nombre del pájaro es: "+pajaro.getNombre());
            pajaro.Mover();
            pajaro.Volar();
            Perro perro = new Perro();
            perro.setNombre("Firulais");
            Console.WriteLine("El nombre del perro es: "+perro.getNombre());
            perro.Mover();
            perro.Ladrar();
            
        }
    }
}