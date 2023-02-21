using System;
namespace FactoryPattern
{
	public class Taco : ITacoTruck
	{
		public Taco()
		{
		}

		public void Order()
		{
			Console.WriteLine("¡The tacos are loco good!");
		}
	}
}

