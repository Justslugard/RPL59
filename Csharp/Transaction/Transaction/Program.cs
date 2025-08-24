using System.Globalization;

namespace Transaction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Trans> ts = new List<Trans>();

            ts.Add(new Trans { Name = "Buku", Category = "Alat Tulis", Price = 15000, Quantity = 2, Stock = 20 });
            ts.Add(new Trans { Name = "Pensil", Category = "Alat Tulis", Price = 2000, Quantity = 10, Stock = 50 });
            ts.Add(new Trans { Name = "Laptop", Category = "Elektronik", Price = 30000, Quantity = 1, Stock = 5 });
            ts.Add(new Trans { Name = "Pulpen", Category = "Alat Tulis", Price = 5000, Quantity = 5, Stock = 8 });
            ts.Add(new Trans { Name = "Headset", Category = "Elektronik", Price = 25000, Quantity = 2, Stock = 3 });
            ts.Add(new Trans { Name = "Penghapus", Category = "Alat Tulis", Price = 1000, Quantity = 3, Stock = 15 });

            Console.WriteLine("=== Total Belanja ===");
            int total = 0;
            foreach (var item in ts)
            {
                total += TotalPrice(item.Price, item.Quantity);
            }
            Console.WriteLine($"Total Price: {total.ToString("C", new CultureInfo("id-ID"))}\n");

            Console.WriteLine("=== Cek Stock ===");
            foreach (var i in ts)
            {
                Stock(i.Stock, i.Name);
            }
            Console.WriteLine();

            Console.WriteLine("=== Total Kumulatif Belanja Lebih Dari 50 rb");
            int tots = 0;
            foreach (var i in ts)
            {
                if (tots > 5e4) break;
                tots += i.Price;
            }

            Console.ReadKey();
        }
        static int TotalPrice(int price, int quantity)
        {
            if (price > 2e4)
            {
                return (int)(price * quantity * 0.9);
            }
            else
            {
                return price * quantity;
            }
        }
        static void Stock(int st, string name)
        {
            if (st < 10)
            {
                Console.WriteLine($"{name} is low on stock!");
            }

        }
    }
    class Trans
    {
        public string Name { get; set; } = "Void";
        public string Category { get; set; } = "Void";
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int Stock { get; set; }
    }
}
