using System;

namespace practica
{
    class Program
    {
        static void Main(string[] args)
        {
            Mamifero animal = new Mamifero("Junco");
            animal.getNombre();

            Caballo babieca = new Caballo("Babieca");
            Console.WriteLine($"Babieca tiene {babieca.numeroPatas()} patas");
        }        
    }

    interface IMamiferoPatas{
        int numeroPatas();
    }

    class Mamifero{
        public Mamifero (String nombre){
            nombreSerVivo = nombre;
        }

        public void respirar(){
            Console.WriteLine("Soy capaz de respirar");
        }
        
        public void getNombre(){
            Console.WriteLine($"El nombre es: {nombreSerVivo}");
        }
        public virtual void pensar(){
            Console.WriteLine($"Pensamiento básico instintivo");
        }

        private String nombreSerVivo;
    }
    class Caballo : Mamifero, IMamiferoPatas{       //Hijo : Padre, Interface 
        public Caballo(String nombreCaballo) : base(nombreCaballo){

        }

        public void galopar(){
            Console.WriteLine("Soy capaz de galopar");
        }
        public int numeroPatas(){
            return 4;
        }
    }
    class Humano : Mamifero{        //Hijo : Padre
        public Humano(String nombreHumano) : base(nombreHumano){

        }

        public override void pensar(){
            Console.WriteLine("Soy capaz de pensar");
        }
    }
    class Gorila : Mamifero{        //Hijo : Padre
        public Gorila(String nombreGorila) : base(nombreGorila){
        }
        public void trepar(){
            Console.WriteLine("Soy capaz de trepar");
        }
        public override void pensar(){
            Console.WriteLine("Pensamiento instintivo avanzado");
        }
    }    

}
