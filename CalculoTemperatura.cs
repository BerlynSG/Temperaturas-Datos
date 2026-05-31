using System;
using System.Linq;

namespace T2
{
	public class CalculoTemperatura
	{
		private readonly double[] temperaturas = new double[10];

        public void EstablecerTemperatura(int dia)
        {
            while (true)
            {
                Console.Write($"Día {dia + 1}: ");
                string? linea = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(linea))
                {
                    Console.WriteLine("Entrada vacía. Intente nuevamente.");
                    continue;
                }

                if (double.TryParse(linea, out double valor))
                {
                    temperaturas[dia] = valor;
                    break;
                }

                Console.WriteLine("Entrada inválida. Ingrese un número (ej. 23.5 o 23,5).");
            }
        }

        public void MostrarTemperaturas()
        {
            Console.WriteLine($"Temperatura más alta: {TemperaturaMaxima():F2} °C");
			Console.WriteLine($"Temperatura más baja: {TemperaturaMinima():F2} °C");
			Console.WriteLine($"Promedio de temperaturas: {Promedio():F2} °C");
			Console.WriteLine($"Días por encima de 30°C: {DiasPorEncimaDe(30)}");
        }

		double TemperaturaMaxima()
		{
			return temperaturas.Max();
		}

		double TemperaturaMinima()
		{
			return temperaturas.Min();
		}

		double Promedio()
		{
			return temperaturas.Average();
		}

		int DiasPorEncimaDe(double limite)
		{
			return temperaturas.Count(t => t > limite);
		}
	}
}

