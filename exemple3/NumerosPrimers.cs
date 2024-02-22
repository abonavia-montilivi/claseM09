using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemple3
{
	internal class NumerosPrimers
	{
		int[] valors = new int[1000];
		public void inicialitzar()
		{
			Random r = new Random();
			for (int i = 0;i<valors.Length;i++)
			{
				valors[i] = r.Next(1,999);
			}
		}

		public bool esPrimer(int valor)
		{
			int divisor = 2;
			while(valor % divisor !=0 && divisor < valor)
			{
				divisor++;
			}
			return (divisor == valor);
		}

		public int calcularQuansSonNumerosPrimers()
		{
			int nPrimers = 0;
			foreach (int i in valors)
			{
				if (esPrimer(i))
				{
					nPrimers++;
					Console.WriteLine(i);
				}
			}
			return nPrimers;
		}

		public int calcularQuansSonNumerosPrimersAmbFils()
		{
			//Dividir el vector en dues parts. (no és important que siguin iguals)
			//Funció per calcular quans son primers d'un index a un altre index del vector
			//Llançar T1, calculant la primera meitat
			//Llançar T2 calculant la segona meitat
			//Sumar quants valors son els primers


			return 0;
		}
	}
}
