using System;

namespace calculadoraDePromedios
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, p;
            Console.WriteLine("Bienvenido a la calculadora de promedios, por favor ingrese la nota obtenida en el primer examen");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Por favor ingrese la nota obtenida en el segundo examen:");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Por favor ingrese la nota obtenida en el tercer examen:");
            n3 = int.Parse(Console.ReadLine());
            p = (n1 + n2 + n3) / 3;
            Console.WriteLine("El promedio obtenido por el alumno es de: " + p);
            Console.WriteLine("Gracias por ultilizar la calculadora de promedios");
        }
    }
}
