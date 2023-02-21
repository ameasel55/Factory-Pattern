using System;
namespace FactoryPattern
{
	public class Torta : ITacoTruck
	{
		public Torta()
		{
		}
		public void Order()
		{
			Console.WriteLine("¡These tortas are buena y sabrosa!");
		}
	}
}

