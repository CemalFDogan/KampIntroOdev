using System;

namespace Events
{

    public delegate void StockControl();
    internal class Program
    {
        static void Main(string[] args)
        {
            Product harddisk = new Product(50);
            harddisk.ProductName = "Hard Disk";

            Product gsm = new Product(50);
            gsm.ProductName = "GSM";
            gsm.StockControlEvent += Gsm_StockControlEvent;

            for (int i = 0; i < 10; i++)
            {
                harddisk.Sell(10);
                gsm.Sell(10);
                Console.ReadLine();
            }
            Console.ReadLine();
        }

        private static void Gsm_StockControlEvent()
        {
            Console.WriteLine("GSM about to finish!!");
        }
    }

    public class Product
    {
        private int _stock;

        public Product(int stock)
        {
            _stock = stock;
        }

        public event StockControl StockControlEvent;
        public string ProductName { get; set; }
        public int Stock
        {
            get
            {
                return _stock;
            }
            set 
            {
                _stock = value;
                if (value<=15 && StockControlEvent != null)
                {
                    StockControlEvent();
                }
            }
    }
        public void Sell(int amount)
        {
            Stock -= amount;

            Console.WriteLine("{0} Stock amount : {1}",ProductName, Stock);
        }
    }
}
