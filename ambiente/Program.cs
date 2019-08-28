using System;

namespace ambiente
{
    class Program
    {
        static void Main(string[] args)
        {
            Objeto obj = new Objeto();
            Objeto obj1 = new Objeto(12,32,"rojo","piedra",47);
            obj.Ancho = 12;
            obj.Color = "negro";
            obj.Alto = 32;
            Console.WriteLine("este es el primer objeto obj");
            Console.WriteLine($"alto={obj.Alto}");
            Console.WriteLine($"alto={obj.Ancho}");
            Console.WriteLine($"alto={obj.Color}");
            Console.WriteLine($"alto={obj.Material}");
            Console.WriteLine($"alto={obj.Largo}");
            Console.WriteLine("este es el primer objeto obj1");
            Console.WriteLine($"alto={obj.Alto}");
            Console.WriteLine($"alto={obj.Ancho}");
            Console.WriteLine($"alto={obj.Color}");
            Console.WriteLine($"alto={obj.Material}");
            Console.WriteLine($"alto={obj.Largo}");
            obj1.ImprimirDato();
            obj1.IngresarDatos();
            obj1.modificarMaterial("bloque");
            obj1.ImprimirDato();








        }
    }
}
