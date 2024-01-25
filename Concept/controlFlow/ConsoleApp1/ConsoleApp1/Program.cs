namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Control Flow!\n");
            Console.WriteLine("if / else if Statement\n");

            int hour = 15;

            if (hour > 0 && hour < 12) {
                Console.WriteLine("It is Morning!");
            } else if(hour >= 12 && hour < 18) {
                Console.WriteLine("It is Afternoon!");
            } else  {
                Console.WriteLine("It is Evening!");
            } 

            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*\n");
            Console.WriteLine("Conditional Operator\n");
            

            bool isGoldCustomer = true;

            float price;
            if (isGoldCustomer)
                price = 19.95f;
            else price = 29.95f;

            float price2 = (isGoldCustomer) ? 19.95f : 29.95f;

            Console.WriteLine(price);
            Console.WriteLine(price2);

            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*\n");
            Console.WriteLine("Conditional Operator\n");

            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It is Autumn & a Beautiful season.");
                    break;
                case Season.Summer:
                    Console.WriteLine("It is perfect to got to beach.");
                    break;
                default:
                    Console.WriteLine("I don't understand that season.");
                    break;
            }

        }
    }
}
