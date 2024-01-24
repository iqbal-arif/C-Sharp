using System;
//System is a namespace
namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! From C-SHARP OF MOSH");

            // Variale and Const
            // Can use VAR at the beginning of each Identifier except for byte DataType

            //byte number = 2;
            byte number = 2;
            Console.WriteLine(number);

            //int count = 10;
            var count = 10;

            //float totalPrice = 20.95f;
            var totalPrice = 20.95f;

            char character = 'A';
            //var character = 'A';

            //string firstName = "Arif";
            var firstName = "Arif";

            //bool isWorking = false;
            var isWorking = false;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            // int Error; When the Identifier is Declared but not Initialized with value;
            // flota Error : Put f after value; C# will not implicity convert the defautl Double Type to Float.
            //Console is a Class defined in System namespace

            //Find the range of DataType with Fromat Sting Template

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            //Constants

            const float Pi = 3.14f;
            //Pi = 4;  means value cannot be changed due to const declaration.
            Console.WriteLine(Pi);

            //Type Conversion

            //NO Data Loss
            byte b = 1;
            int i = b;
            Console.WriteLine(i);

            // Data Loss
            int x = 1;
            byte y = (byte)x; // casted it to avoid error
            Console.WriteLine(y);
            // Data loss with Casting
            int z = 1000;
            byte w = (byte)z; // casted it to avoid error; RETURN value is 232 DATA LOSS
            //Cannot fit 1000 int into byte.(capacity of bity is 255 max)
            Console.WriteLine(w);

            //Non Compatible Type

            //Example 1 // 
            var numberString = "1234";
            //Cannot convert string to int
            //int iNumber = (int)numberString; 
            int iNumber = Convert.ToInt32(numberString);
            Console.WriteLine($"String to Number, {iNumber}");

            //Crashes the Software because string cannot fit in byte
            //Redoing in next step but with catch and throw block
            //byte iByte = Convert.ToByte(numberString);
            //Console.WriteLine($"String to Byte, {iByte}"); 

            //Here is the Fix: USE TRY and CATCH Block
            //System will handle this exception.

            try
            {
                var numberStringValue = "4567";
                byte stringToByte = Convert.ToByte(numberStringValue);
                Console.WriteLine(stringToByte);

            }
            catch (Exception)
            {
                Console.WriteLine("The nubmer could not be conveted to a byte.");
            }

            //Another Example

            try
            {
                //If the string values are "TRUE" or "FLASE" it will convert to Boolean
                //Any other string will not be conveted to Boolean
                string stringValue = "fALSENot";  // Type True or False and Re-RUN
                bool toBoolean = Convert.ToBoolean(stringValue);
                Console.WriteLine($"The string value is {stringValue}, therefore, it can be converted to {toBoolean}");

            }
            catch (Exception)
            {
                Console.WriteLine($"The String could not be conveted to a Boolean Because the stringValue is not True or False.");
            }

            //Arithmatic Operator
            var p = 10;
            var q = 3;
            var c = 5;

            Console.WriteLine(p+q);
            Console.WriteLine(p/q); //sigle digit number
            Console.WriteLine((float)p / (float)q); //floating casting will give decimal values

            Console.WriteLine(p + q * c); //Arithmatic law applies PEMDAS

            Console.WriteLine(p != q);    //True
            Console.WriteLine(!(p != q)); //False : can convert to (p == q) same result
            Console.WriteLine(p > c && p > q);
            Console.WriteLine(p > c && p == q);
            Console.WriteLine(p > c || p == q);
        }
    }
}
