namespace Labb4_Generic_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var restaurant = new Restaurant();

            var menu = new List<MenuItem>()
            {
                new MenuItem(0, "Carbonara", 129.00m),
                new MenuItem(1, "Margherita", 99.00m),
                new MenuItem(2, "Cheeseburgare", 149.00m),
                new MenuItem(3, "Caesarsallad", 89.00m)
            };

            foreach (var menuItem in menu)
            {
                restaurant.AddToMenu(menuItem);
            }

            restaurant.ShowMenu();

            var orders = new List<Order>()
            {
                new Order([menu[0], menu[2]], 1),
                new Order([menu[1], menu[2]], 2),
                new Order([menu[3], menu[0]], 3)
            };

            foreach (var order in orders)
            {
                restaurant.CreateOrder(order);
            }

            restaurant.ShowOrders();
            restaurant.ShowOrderCount();

            restaurant.ShowNextOrder();
            restaurant.HandleOrder();
            restaurant.ShowOrderCount();

            restaurant.CreateOrder(new Order([menu[2], menu[1]], 2));
            restaurant.ShowOrderCount();

            restaurant.HandleOrder();
            restaurant.HandleOrder();
            restaurant.ShowOrderCount();

            restaurant.ShowNextOrder();
            restaurant.HandleOrder();
            restaurant.ShowOrderCount();
        }
    }
}
