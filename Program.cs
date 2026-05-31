using System;

namespace T2
{
	class Program
	{
		static void Main(string[] args)
		{

			var calculo = new CalculoTemperatura();

			Console.WriteLine("Ingrese las temperaturas para 10 días (°C). Use punto o coma para decimales.");

			for (int i = 0; i < 10; i++)
			{
                calculo.EstablecerTemperatura(i);
			}

			Console.WriteLine();
            calculo.MostrarTemperaturas();
		}
	}
}

