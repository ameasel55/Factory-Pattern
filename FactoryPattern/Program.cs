namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your order total");

            double orderTotal;
            
            var input = double.TryParse(Console.ReadLine(), out orderTotal);

            ITacoTruck order = TacoFactory.PlaceOrder(orderTotal);
            order.Order();

        }
        
    }
}
 