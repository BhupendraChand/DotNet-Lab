using System;

    public class Person
    {
        public void sendMsg(String name, double op, double np)
        {
            Console.WriteLine("The price of stock " +
                name + " is changed from " + op + " to " + np);
        }
    }
    public delegate void priceChange(string name, double op, double np);
    public class stockTicker
    {
        public event priceChange pc;
        public string name { get; set; }
        public double price;
        public double Price
        {
            get { return price; }
            set
            {
                double oldprice = price;
                price = value;
                if (pc != null)
                {
                    pc(name, oldprice, price);
                }

            }

        }

    }
    public class qno3
    {
        private static string name;

        public static int Price { get; private set; }

        public static void Main(string[] args)
        {
            Person person = new Person();
            stockTicker stock = new stockTicker();
            {
                name = "Nabil"; Price = 500;
            }
            stock.pc += person.sendMsg;
            stock.Price = 550;
        stock.Price = 700;
        Console.ReadKey();
        }
    }

