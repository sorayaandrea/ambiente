using System;
using System.Collections.Generic;
using System.Text;

namespace ambiente
{
    class Objeto
    {
        #region propiedades

        public double Alto { get; set; }
        public double Ancho { get; set; }
        public string  Color{ get; set; }
        public string Material { get; set; }
        public double Largo { get; set; }

        #endregion
        #region constructores 
        public Objeto()
        {

        }
        public Objeto(double alto, double ancho, string color, string material, double largo)
        {
            Alto = alto;
            Ancho = ancho;
            Color = color;
            Material = material;
            Largo = largo;
        }
        public Objeto(string material,string color,double ancho)
        {
            Material = material;
            Color = color;
            Ancho = ancho;
                
        }

        #endregion

        #region metodos
        public void IngresarDatos()
        {
            Console.WriteLine("ingresar material");
            Material = Console.ReadLine();
            Console.WriteLine("ingresar color");
           Color = Console.ReadLine();
            Console.WriteLine("ingresar ancho");
            Ancho = double.Parse(Console.ReadLine());
            Console.WriteLine("ingresar alto");
            Alto = double.Parse(Console.ReadLine());
            Console.WriteLine("ingresar ancho");
            Largo = double.Parse(Console.ReadLine());



        }
        public void ImprimirDato()
        {
            Console.WriteLine($"alto:{Alto}");
            Console.WriteLine($"ancho:{Ancho}");
            Console.WriteLine($"alto:{Color}");
            Console.WriteLine($"ancho:{Material}");
            Console.WriteLine($"alto:{Largo}");
           
        }
       

        public void modificarMaterial(string M)
        {
            Material = M;
        }

        #endregion



    }
}
