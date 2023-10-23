
namespace Herencia02{
    public class Perro : Animal{
        public Perro(string nombre) : base(nombre){ //base: llama al constructor de la clase base
        }
        public void Ladrar(){
            Console.WriteLine($"{nombre} está ladrando.");
        }
        public override void Comer(){
            Console.WriteLine("El perro  cominedo.  (Sobreescrito) ");
            Console.WriteLine($"{nombre} está comiendo croquetas.");
        }
    }


}