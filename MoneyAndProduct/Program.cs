namespace MoneyAndProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    internal class Money
    {
        private int dollars;
        private int pennies;

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
        public int Pennies { 
            get 
            {
                return pennies; 
            } 
            set 
            {
                if (value < 0 || value > 99)
                {
                    Console.WriteLine("Pennies should be between 0-99")
                } else
                {
                    pennies = value;
                }
            } 
        }

    }
}
