using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Numerics;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
           
           //While loop with Summation

            //int sum = 0;

            while (true)
            {

                Console.WriteLine("Enter a Number or OK to Exit!!");
                var input2 = Console.ReadLine();
                
                Console.WriteLine(@"You Entered : " + input2);
                   
               if (System.String.IsNullOrWhiteSpace(input2)) // if there is an input due !
                {
                  continue;
                } else if (input2.ToUpper() == "OK")
                {

                    break;
                }
             
                   // count++;
                   /* inputSum[count] = Convert.ToInt32(input);
                    sum = sum + inputSum[count];*/

                   // sum = sum + Convert.ToInt32(input); // summation
                    //Console.WriteLine("Your Entered Number Summation is : " + inputSum.Sum()); // goes with array
                  //  Console.WriteLine("Your Entered Number Summation is : " + sum); //summation
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
             Console.WriteLine(@"7 - Write a program and ask the user to enter a series of numbers
 separated by comma. Find the maximum of the numbers and display it on the console. For example,
 if the user enters “5, 3, 8, 1, 4"", the program should display 8.\n");
             Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*\n");

             Console.WriteLine("Enter a Number to Compute the Factorial!!");
             int inputFactorial = Convert.ToInt32(Console.ReadLine());
             int factorial=1;
             for(int i = inputFactorial; i >= 1; i--) {
                 factorial = factorial * i;

             }
                 Console.WriteLine(factorial);
            */
            /*
            Console.WriteLine("\n*-*-*-*-*-*-*-*-*-*-*-*-*-*\n");
            Console.WriteLine(@"8 - Write a program that picks a random number between 1 and 10.
Give the user 4 chances to guess the number. If the user guesses the number, display “You won"";
otherwise, display “You lost"". (To make sure the program is behaving correctly, you can display
the secret number on the console first.)\n");
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*\n");

            Random random = new Random();

            int guessNumber = 0;

            for (; guessNumber != 100;)
            {
                int randomNumber = random.Next(1,10);
                Console.WriteLine("Enter Random Number or 100 to EXIT\n");
                guessNumber = Convert.ToInt32(Console.ReadLine());
               // Console.WriteLine($"Guess Number: {guessNumber}");
                if (randomNumber == guessNumber)
                {
                    Console.WriteLine("You Won\n");
                }
                else
                {
                    Console.WriteLine("You Lost\n");
                }
            }
            */
            Console.WriteLine("\n*-*-*-*-*-*-*-*-*-*-*-*-*-*\n");
            Console.WriteLine(@"9 -  Write a program and ask the user to enter a series of numbers
separated by comma. Find the maximum of the numbers and display it on the console. For example,
if the user enters “5, 3, 8, 1, 4"", the program should display 8.\n");
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*\n");


            Console.WriteLine("Enter number in Series!\n");

            var series = new List<string>();


            var maxNum = 0;



            var userInput = Console.ReadLine() ?? ""; //The null-coalescing operator ??
            var userInputSplit = userInput.Split(","); // 

            
             //* *******LIST SOLUTION WITH FOREACH APPROACH*******
             /*

            foreach ( var num in userInputSplit )
            {
                var number = Convert.ToInt32(num);

                if (number > maxNum)
                {
                    maxNum = number;
                }
            }

            Console.WriteLine($"The Maximum Number {maxNum} " );
           
            */

            /*
             * *******STRING ARRAY SOLUTION*******
            string[] numberStr = userInput.Split(',');

            for (int i = 0; i < numberStr.Length; i++)
            {
                var number = Convert.ToInt32(numberStr[i].Trim());
               // series.Add(number);
                
                if(number > maxNum) {
                    maxNum = number;
                }
              Console.WriteLine("The Maximum Number is : " + maxNum);
            */


            //********LIST SOLUTION WITH FOR LOOP APPROACH*******

            for (int i = 0; i < userInputSplit.Length; i++)
            {
                var number = Convert.ToInt32(userInputSplit[i]);
                
                if (number > maxNum)
                {
                    maxNum = number;
                }
            }
                    Console.WriteLine($"The Maximum Number is : {maxNum}");
            
            Console.ReadLine();
           



        

        }


    }
}
