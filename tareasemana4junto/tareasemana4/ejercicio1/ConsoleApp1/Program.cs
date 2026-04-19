using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
			//entradas
			Console.Write("Ingrese el monto de la compra (S/): ");
			double monto = double.Parse(Console.ReadLine());

			//operaciones
			double descuento = 0;

			if (monto >= 100)
			{
				descuento = monto * 0.10;
			}

			double total = monto - descuento;

			//salida
			Console.WriteLine($"Descuento aplicado: S/ {descuento:F2}");
			Console.WriteLine($"Total a pagar: S/ {total:F2}");

			Console.ReadKey();
		}
    }
}
