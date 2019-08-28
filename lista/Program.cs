using System;
using System.Collections.Generic;

namespace lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            var diasSemana = new List<string>();
            numeros.Add(5);
            numeros.Add(6);
            numeros.Add(5);
            numeros.Add(30);
            diasSemana.Add("lunes");
            diasSemana.Add("domingo");
            Console.WriteLine("esta es la lista de numeros ");
            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("esta es la lista de la semana");
            foreach (var item2 in diasSemana)
            {
                Console.WriteLine(item2);
            }
            Console.WriteLine("Elinina a 50 men de la lista");
            numeros.Remove(50);
            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }






        }
    }
}
