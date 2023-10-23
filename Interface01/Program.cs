namespace Interface01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAves[] voladores = new IAves[3];
            voladores[0] = new Murcielago();
            voladores[1] = new Paloma();
            voladores[2] = new Murcielago();

            foreach (IAves volador in voladores)
            {
                Console.WriteLine("Soy un " + volador.GetType().Name);
                volador.Volar();
            }

            Console.WriteLine("**************");

            IMamifero[] mamiferos = new IMamifero[2];
            mamiferos[0] = new Murcielago();
            mamiferos[1] = new Ballena();

            foreach (IMamifero mamifero in mamiferos)
            {  
                Console.WriteLine("Soy un " + mamifero.GetType().Name);
                mamifero.Amamantar();
            }
        }
    }



    interface IAves
    {
        void Volar();
    }
    interface IMamifero
    {
        void Amamantar();
    }
   
    class Murcielago : IAves, IMamifero
    {
        public void Volar()
        {
            Console.WriteLine("Estoy volando como un murcielago");
        }
        public void Amamantar()
        {
            Console.WriteLine("Estoy amamantando como un murcielago");
        }
    }

    class Ballena : IMamifero
    {
        public void Amamantar()
        {
            Console.WriteLine("Estoy amamantando como una ballena");
        }
    }
    class Paloma : IAves
    {
        public void Volar()
        {
            Console.WriteLine("Estoy volando como paloma");
        }
    }

}

