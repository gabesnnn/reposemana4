using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Console.Write("Ingrese examen parcial: ");
			double parcial = Convert.ToDouble(Console.ReadLine());

			Console.Write("Ingrese examen final: ");
			double final = Convert.ToDouble(Console.ReadLine());

			Console.Write("Ingrese práctica 1: ");
			double p1 = Convert.ToDouble(Console.ReadLine());

			Console.Write("Ingrese práctica 2: ");
			double p2 = Convert.ToDouble(Console.ReadLine());

			Console.Write("Ingrese práctica 3: ");
			double p3 = Convert.ToDouble(Console.ReadLine());

			// Encontrar la menor práctica
			double menor = Math.Min(p1, Math.Min(p2, p3));

			// Promedio de las 2 mejores prácticas
			double prom_prac = (p1 + p2 + p3 - menor) / 2;

			// Promedio final
			double prom_final = (parcial + final + prom_prac) / 3;

			Console.WriteLine("Promedio de prácticas: " + prom_prac);
			Console.WriteLine("Promedio final: " + prom_final);

			// Clasificación
			if (prom_final >= 18)
			{
				Console.WriteLine("Excelente");
			}
			else if (prom_final >= 14)
			{
				Console.WriteLine("Bueno");
			}
			else if (prom_final >= 10)
			{
				Console.WriteLine("Regular");
			}
			else
			{
				Console.WriteLine("Deficiente");
			}

			Console.ReadKey();
		}
    }
}
