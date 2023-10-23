
namespace Herencia
{
    class Animal
    {
        private string nombre="animal";
        //getter y setter
        public string getNombre()
        {
            return nombre;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        
        public void Mover()
        {
            Console.WriteLine("El animal se está moviendo...");
        }
    }
}
