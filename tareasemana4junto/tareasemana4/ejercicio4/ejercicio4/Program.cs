using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
			// Entradas
			Console.Write("Ingrese categoría (A, B, C): ");
			string cat = Console.ReadLine().ToUpper();

			Console.Write("Ingrese horas trabajadas: ");
			double horas = double.Parse(Console.ReadLine());

			Console.Write("Ingrese años de servicio: ");
			int anios = int.Parse(Console.ReadLine());

			double tarifa = 0;

			// Tarifa por categoría
			if (cat == "A") tarifa = 33.50;
			else if (cat == "B") tarifa = 29.80;
			else if (cat == "C") tarifa = 25.70;
			else
			{
				Console.WriteLine("Categoría inválida");
				return;
			}

			double bono = 0;

			// Bono por años
			if (anios <= 3) bono = 0.00;
			else if (anios >= 4 && anios <= 10) bono = 0.10;
			else if (anios >= 11 && anios <= 17) bono = 0.20;
			else bono = 0.30;

			// Cálculo final
			double sueldoFinal = tarifa * horas * (1 + bono);

			// Salida
			Console.WriteLine($"Sueldo: S/. {sueldoFinal:F2}");
		}
    }
}
