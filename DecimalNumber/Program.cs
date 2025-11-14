namespace DecimalNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            DecimalNumber decimalNumber = new DecimalNumber();
            Console.WriteLine(decimalNumber.ToBinary(num));
            Console.WriteLine(decimalNumber.ToOctal(num));
            Console.WriteLine(decimalNumber.ToHex(num));
        }
    }

    struct DecimalNumber
    {
        public int Number;
        public DecimalNumber(int number)
        {
            Number = number;
        }

        public string ToBinary(int number)
        {
           return Convert.ToString(number, 2);
        }
        public string ToOctal(int number)
        {
            return Convert.ToString(number, 8);
        }
        public string ToHex(int number)
        {
            return Convert.ToString(number, 16);
        }
    }
}
