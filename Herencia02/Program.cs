//Constructores en la Herencia
//Sobreescritura de métodos
namespace Herencia02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal("Animal");
            a.Comer();
            Console.WriteLine(a.getNombre());
            Console.WriteLine();
            Perro p = new Perro("Firulais");
            p.Comer();
            p.Ladrar();
            Console.WriteLine(p.getNombre());
            Console.ReadKey();
        }
    }
}