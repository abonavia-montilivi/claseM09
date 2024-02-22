namespace exemple3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var np = new NumerosPrimers();
			np.inicialitzar();

			var start = DateTime.Now;
            Console.WriteLine(np.calcularQuansSonNumerosPrimers());
			var diff = DateTime.Now- start;
            Console.WriteLine("Temps invertit:" + diff.TotalMilliseconds);

			start = DateTime.Now;
			Console.WriteLine(np.calcularQuansSonNumerosPrimersAmbFils());			
			diff = DateTime.Now - start;
			Console.WriteLine("Temps invertit:" + diff.TotalMilliseconds);
        }
	}
}