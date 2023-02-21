using System;
namespace FactoryPattern
{
	public class Dessert : ITacoTruck
	{
		public Dessert()
		{
		}
		public void Order()
		{
			Console.WriteLine("¡This dessert is delicioso!");
		}
	}
}

