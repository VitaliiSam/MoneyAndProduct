namespace MoneyAndProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //first part with Money class only
            //Money wallet = new Money(125, 90);
            //Console.WriteLine("Enter dollars: ");
            //wallet.Dollars = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter cents:");
            //wallet.Cents = int.Parse(Console.ReadLine());
            //wallet.SetAmount(wallet.Dollars, wallet.Cents);
            //wallet.ShowAmount();


            //second part with product
            Product apple = new Product("Phone17", new Money(1250, 50));

            
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("1.Show product");
                Console.WriteLine("2.Increase price");
                Console.WriteLine("3.Descrease price");
                Console.WriteLine("4.Exit");

                Console.Write("Your choice: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        apple.ShowProduct();
                        break;
                    case "2":
                        Console.WriteLine("How much dollars?");
                        int incrDollars = int.Parse(Console.ReadLine());
                        Console.WriteLine("How much cents?");
                        int incrCents = int.Parse(Console.ReadLine());
                        apple.IncreasePrice(new Money(incrDollars, incrCents));
                        break;
                    case "3":
                        Console.WriteLine("How much dollars?");
                        int decrDollars = int.Parse(Console.ReadLine());
                        Console.WriteLine("How much cents?");
                        int decrCents = int.Parse(Console.ReadLine());
                        apple.DecreasePrice(new Money(decrDollars, decrCents));
                        break;
                    case "4":
                        exit = true;
                        break;
                }
            }
        }
    }
    internal class Money
    {
        private int dollars;
        private int cents;

        public Money(int dollars, int cents)
        {
            this.dollars = dollars;
            this.cents = cents;
        }
        public int Dollars { 
            get 
            { 
                return dollars;
            } 
            set 
            {
                if (value < 0)
                {
                    Console.WriteLine("Can't be negative value");
                } else
                {
                    dollars = value;
                } 
            } 
        }
        public int Cents { 
            get 
            {
                return cents; 
            } 
            set 
            {
                if (value < 0 || value > 99)
                {
                    Console.WriteLine("Cents test should be between 0-99");
                } else
                {
                    cents = value;
                }
            } 
        }
        public void ShowAmount()
        {
            Console.WriteLine($"{dollars}.{cents} usd");
        }
        public void SetAmount(int dollars, int cents)
        {
            if( dollars < 0 )
            {
                Console.WriteLine("Can't be negative value");
                return;
            }
            if( cents < 0 || cents > 99)
            {
                Console.WriteLine("Cents should be between 0-99");
                return;
            }
            this.dollars = dollars;
            this.cents = cents;
        }
        public void NormalizeCentsInDollars()
        {
            if(cents >= 100)
            {
                dollars += cents / 100;
                cents %= 100;
            }
        }
        public void Add (Money other)
        {
            dollars += other.dollars;
            cents += other.cents;
            NormalizeCentsInDollars();
        }
        public void Subtract (Money other)
        {
            dollars -= other.dollars;
            cents -= other.cents;
            NormalizeCentsInDollars();
        }
    }
    internal class Product
    {
        private string name;
        private Money price;

        public Product (string name, Money price)
        {
            this.name = name;
            this.price = price;
        }
        public void IncreasePrice(Money amount)
        {
            price.Add(amount);
            Console.WriteLine("Price increased");
        }
        public void DecreasePrice(Money amount)
        {
            price.Subtract(amount);
            Console.WriteLine("price descreased");
        }
        public void ShowProduct()
        {
            Console.Write($"Product {name}, price: ");
            price.ShowAmount();
        }
    }
}
