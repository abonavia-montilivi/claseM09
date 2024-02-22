using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple_2
{
	internal class SumaValor
	{
		int valor=0;
		int nFilsQueHanAcabat = 0;
		static readonly object locker = new object();
		public void inicialitzar()
		{
			Thread t1 = new Thread(sumaAValor);
			t1.IsBackground = true;
			t1.Start();

			Thread t2 = new Thread(sumaAValor);
			t2.IsBackground = true;
			t2.Start();
			while (nFilsQueHanAcabat != 2)
			{
				;
			}
			
            Console.WriteLine($"El resultat és:{valor}");
        }

		void sumaAValor()
		{
			for (int i = 0; i < 9000000; i++)
			{
				lock (locker)
				{
					valor++;
				}
			}
			nFilsQueHanAcabat++;
		}
	}
}