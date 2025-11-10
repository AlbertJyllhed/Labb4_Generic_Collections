namespace Labb4_Generic_Collections
{
    internal class Restaurant
    {
        List<MenuItem> Menu { get; set; } = [];
        Queue<Order> Orders { get; set; } = [];

        public void AddToMenu(MenuItem menuItem)
        {
            Menu.Add(menuItem);
            Console.WriteLine($"{menuItem.ToString()} har lagts till i menyn.");
        }

        public void ShowMenu()
        {
            Console.WriteLine("Meny:");
            for (int i = 0; i < Menu.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Menu[i].Name} - {Menu[i].Price} kr");
            }
        }

        public void CreateOrder(Order order)
        {
            Orders.Enqueue(order);
            Console.WriteLine($"Beställning nr {order.GetOrderId()} har lagts till.");
        }

        public void HandleOrder()
        {
            var order = Orders.Dequeue();
            Console.WriteLine($"Order {order.GetOrderId()} färdig.");
        }

        public void ShowOrders()
        {
            Console.WriteLine("Aktuella beställningar:");
            foreach (var order in Orders)
            {
                order.DisplayOrderInfo();
            }
        }

        public void ShowNextOrder()
        {
            Console.WriteLine("Nästa order i kön:");
            Orders.Peek().DisplayOrderInfo();
        }

        public void ShowOrderCount()
        {
            if (Orders.Count == 1)
            {
                Console.WriteLine($"Det är {Orders.Count} order i kön.");
            }
            else if (Orders.Count > 1)
            {
                Console.WriteLine($"Det är {Orders.Count} ordrar i kön.");
            }
            else
            {
                Console.WriteLine("Det finns inga väntande ordrar i kön just nu.");
            }
        }
    }
}
