namespace Labb4_Generic_Collections
{
    internal class Order
    {
        static int orderIdCounter = 1;
        private int _orderId;
        private List<MenuItem> _orderItems;
        private int _tableNumber;

        public Order(List<MenuItem> orderItems, int tableNumber)
        {
            // Automatiskt skapande av id
            _orderId = orderIdCounter;
            orderIdCounter++;
            _orderItems = orderItems;
            _tableNumber = tableNumber;
        }

        public void DisplayOrderInfo()
        {
            Console.WriteLine($"Till bord nummer {_tableNumber}");

            foreach (var order in _orderItems)
            {
                Console.WriteLine(order.ToString());
            }
        }
    }
}
