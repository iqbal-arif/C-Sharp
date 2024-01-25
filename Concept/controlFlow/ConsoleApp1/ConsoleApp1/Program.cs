using System.Threading.Tasks.Dataflow;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            /*
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

            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*\n");
            Console.WriteLine("Iteration Statements\n");
            Console.WriteLine("For Loop\n");

            for (int k = 1; k <= 10; k++) { if (k % 2 == 0) Console.WriteLine(k); }
            for (int j = 10; j >= 10; j--) { if (j % 2 == 0) Console.WriteLine(j); }

            Console.WriteLine("Foreach Loop\n");

            var nameList = "John Smith";
            foreach (char character in nameList)
            {
                Console.WriteLine(character);
            }
            var numbersArray = new int []{ 1, 2, 3, 4 };

             foreach (var item in numbersArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("While Loop\n");

            var i = 0;
            while (i <= 10) {
                if (i % 2 == 0) Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("While Loop For User to Enter the name\n");

            while (true) 
            {
                Console.WriteLine("Type your name!!");
                var input = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(input)) // if there is an input due !
                {
                    Console.WriteLine(@"Echo: " + input);
                    continue;
                }
                    break;
            }
            */
            Console.WriteLine("Random Class\n");

            var random = new Random();
            var randomNum = random.Next();
            Console.WriteLine(randomNum);
            //REWATCH RANDOM CLASS NOT CLEAR
            //do { Console.WriteLine(); }while (true);

            //Casting a key character to an Integer
            Console.WriteLine((int)'a'); //int

            // How generator Randowm Password
            //buffer Array

            const int passwordLength = 16;
            var buffer = new char[passwordLength];

            //Writing Ramdom alphabet ascii code from a-z through loop
            //where a = 97; and z = 122, according to ascii code
            for (int i = 0; i < passwordLength; i++)
                buffer[i] = (char)('a' + random.Next(0, 26));

                //Writing as a string
                var password = new string(buffer);
           
                Console.WriteLine(password); 

            Console.WriteLine((char)random.Next(97,122)); //character from a - z
            Console.Write("*-*-*-*-*-*-*-*-*-*-*-*-*-*\n");
            Console.WriteLine(('a' + random.Next(0, 26))); //int charactor code
            Console.WriteLine((char)('a' + random.Next(0, 26))); //char random

        }
    }
}
