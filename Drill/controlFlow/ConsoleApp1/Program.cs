using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Numerics;

namespace controlFlow
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("1 - Number Validation App!\n");
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*\n");
            Console.WriteLine("Enter Number between 1 and 10.");
            var keyNumber = Convert.ToInt32(Console.ReadLine());

            var result = keyNumber <= 1 || keyNumber <= 10 ? "Valid" : "InValid";
            Console.WriteLine(result);

            Console.WriteLine("\n*-*-*-*-*-*-*-*-*-*-*-*-*-*\n");
            Console.WriteLine("2 - Max of Two numbers App!\n");
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*\n");

            Console.WriteLine("Enter First Number.");

            var firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number.");

            var secondNumber = Convert.ToInt32(Console.ReadLine());

            var maxNumber = Math.Max(firstNumber, secondNumber);
            Console.WriteLine(string.Format("\nThe Max Value {0}",maxNumber));

            Console.WriteLine("\n*-*-*-*-*-*-*-*-*-*-*-*-*-*\n");
            Console.WriteLine("3 - Landscape or Portrait App!\n");
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*\n");

            Console.WriteLine("Enter the image Height.");
            var height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the image Width.");
            var width = Convert.ToInt32(Console.ReadLine());

            var image = height > width ? "Landscape" : "Portrait";
            Console.WriteLine(string.Format("\nThe image layout is {0}",image));

            Console.WriteLine("\n*-*-*-*-*-*-*-*-*-*-*-*-*-*\n");
            Console.WriteLine("4 - License Suspension App!\n");
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*\n");
            Console.WriteLine(@"Your job is to write a program for a speed camera.
For simplicity, ignore the details such as camera, sensors,
etc and focus purely on the logic. Write a program that asks
the user to enter the speed limit. Once set, the program asks
for the speed of a car. If the user enters a value less than
the speed limit, program should display Ok on the console.
If the value is above the speed limit, the program should
calculate the number of demerit points. For every 5km/hr above
the speed limit, 1 demerit points should be incurred and displayed
on the console. If the number of demerit points is above 12, the
program should display License Suspended.");

            Console.WriteLine("Enter the Speed Limit.");
            var limit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Speed of the car.");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            var speedLimit = carSpeed < limit ? "OK" : "License Suspended";
            Console.WriteLine("\n*-*-*-*-*-*-*-*-*-*-*-*-*-*\n");
            Console.WriteLine(@"5 - Write a program to count how many numbers
between 1 and 100 are divisible by 3 with no remainder App!\n");
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*\n");

            var random = new Random();
            var oneTohundred = random.Next(1, 100);
            var divisibleBy3 = 0;

            // divisibleBy3 = counter % 3;
            for (int counter = 1; counter <= 100; counter++)
                if (counter % 3 == 0)
                    divisibleBy3++;

                    Console.WriteLine($"The Total count%3 == 0 is : {divisibleBy3}");
            */

            Console.WriteLine("\n*-*-*-*-*-*-*-*-*-*-*-*-*-*\n");
            Console.WriteLine(@"6 - Write a program and continuously ask the user to
enter a number or ""ok"" to exit. Calculate the sum of all the previously entered
numbers and display it on the console.\n");
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*\n");

            
           // int count = 0;
           // var inputSum = new int[25];
            int sum = 0;
            while (true)
            {
                Console.WriteLine("Enter a Number or OK to Exit!!");
                var input = Console.ReadLine();
                
                Console.WriteLine(@"You Entered : " + input);
                   
                if (String.IsNullOrWhiteSpace(input)) // if there is an input due !
                {
                  continue;
                } else if (input.ToUpper() == "OK")
                {

                    break;
                }
             
                   // count++;
                   /* inputSum[count] = Convert.ToInt32(input);
                    sum = sum + inputSum[count];*/

                    sum = sum + Convert.ToInt32(input);
                    //Console.WriteLine("Your Entered Number Summation is : " + inputSum.Sum());
                    Console.WriteLine("Your Entered Number Summation is : " + sum);
            }
            /*
             //Do While Loop Alternate to While Loop
            string input2;
            do {
                Console.WriteLine("Enter a Number or OK to Exit!!");
                input2 = Console.ReadLine();
                Console.WriteLine();
            }while (input2 !="OK");
            */

            /*
            //Custom For Loop Alternate to While Loop Above
            string input3 = "";
            for (; input3 != "OK"; )
            {
                Console.WriteLine($"{input3}");
                input3 = Console.ReadLine();
            }
            */

            /*
            Console.WriteLine("\n*-*-*-*-*-*-*-*-*-*-*-*-*-*\n");
            Console.WriteLine(@"8 - Write a program and continuously ask the user to
enter a number or ""ok"" to exit. Calculate the sum of all the previously entered
numbers and display it on the console.\n");
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*\n");

            */
            int speed = 65;
            double specified = (int) speed;
            Console.WriteLine(specified);

        }
    }
}
