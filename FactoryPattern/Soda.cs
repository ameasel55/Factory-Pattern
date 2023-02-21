using System;
namespace FactoryPattern
{
	public class Soda : ITacoTruck
	{
		public Soda()
		{
		}

		public void Order()
		{
			Console.WriteLine("¡The soda is muy refrescante!");
		}
		
	}
}

