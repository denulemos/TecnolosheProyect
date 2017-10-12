using System;

namespace Tecnoloshe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Ingrese Edad");
            int edad = int.Parse(Console.ReadLine());
            if (edad>=18)
            {
                Console.WriteLine("Es mayor de edad");
            }
            else
            {
                Console.WriteLine("Es menor, alejateeee");
            }
        }
    }
}
