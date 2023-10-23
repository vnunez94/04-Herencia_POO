
namespace Herencia02
{

    public class Animal
    {
        protected string nombre; //protected: solo se puede acceder desde la clase o sus derivadas
        public Animal(string nombre)
        {
            this.nombre = nombre;
        }
        //getter y setter
        public string getNombre()
        {
            return nombre;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public virtual void Comer() //virtual: permite que se sobreescriba en las clases derivadas
        {
            Console.WriteLine($"{nombre} está comiendo.");
        }
    }

}