namespace Labb4_Generic_Collections
{
    internal class Restaurant
    {
        List<MenuItem> Menu { get; set; } = [];
        Queue<Order> Orders { get; set; } = [];

        public void AddToMenu(MenuItem menuItem)
        {
            Menu.Add(menuItem);
            Console.WriteLine($"Adding {menuItem.ToString()} to the menu.");
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
            Console.WriteLine($"Adding {order} to order list.");
        }

        public void HandleOrder()
        {
            var order = Orders.Dequeue();
            Console.WriteLine($"Handling {order}.");
        }

        public void ShowOrders()
        {
            foreach (var order in Orders)
            {
                order.DisplayOrderInfo();
            }
        }

        public void ShowNextOrder()
        {
            var order = Orders.Peek();
            Console.WriteLine("Next order:");
            order.DisplayOrderInfo();
        }

        public void ShowOrderCount()
        {
            Console.WriteLine($"There are {Orders.Count} orders.");
        }
    }
}
