using System;
namespace FactoryPattern
{
	public static class TacoFactory
	{
		public static ITacoTruck PlaceOrder(double orderTotal)
		{
			switch (orderTotal)
			{
				case 9.50:
					return new Taco();
				case 8.50:
					return new Torta();
				case 5.50:
					return new Dessert();
				case 2.50:
					return new Soda();
				default:
					return new Taco();
			}
		}
	}
}

