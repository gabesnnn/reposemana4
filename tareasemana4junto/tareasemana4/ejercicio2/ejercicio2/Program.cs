using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("menu de operaciones");
			Console.WriteLine("1. calcular area de un circulo");
			Console.WriteLine("2. calcular area de un cuadrado");
			Console.WriteLine("3. calcular area de un triangulo");
			Console.WriteLine("4. salir");
			Console.WriteLine("seleccione una opcion 1-4");

			int opcion = int.Parse(Console.ReadLine());

			switch (opcion)
			{
				case 1:
					Console.WriteLine("area de un circulo = π * r^2");
					break;

				case 2:
					Console.WriteLine("area de un cuadrado = lado * lado");
					break;

				case 3:
					Console.WriteLine("area de un triangulo = (base * altura) / 2");
					break;

				case 4:
					Console.WriteLine("saliendo del programa");
					break;

				default:
					Console.WriteLine("opcion invalida, ingrese un numero del 1 al 4");
					break;
			}

			Console.ReadKey();
		}
    }
}
