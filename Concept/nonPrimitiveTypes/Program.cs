
using nonPrimitiveTypes.Math;

namespace CSharpFundamentals
{


    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("NON-Primitive Types!\n");


            Person john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);

            Console.ReadLine();

            //Array Initialization

            //Integer Array
            var numbers = new int[3];
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            //Boolean Arrray
            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            //String Array
            var names = new string[3] { "Jack", "John", "Mary" };

            var FirstName = "Arif";
            var LastName = "Iqbal";

            var fullName = FirstName + " " + LastName;

            //Sring Fromat Method
            var myFullName= string.Format("My name is {0} - {1}\n",FirstName, LastName);
            Console.WriteLine(myFullName);

            //String Join Method
            var joinedString = string.Join(", ", names);
            Console.WriteLine(joinedString);

            //Verbatim String
            var message = @"Hi John
                            Look at the following paths:
                            c:\folder1\folder2\
                            c:\folder3\folder4";
            Console.WriteLine(message);

            //Enum Method

            var method = ShippingMethod.Express;
            Console.WriteLine((int)method); //Casting give the integer value.

            //Received Data from DataBase and write values in Enum structure
            var methodId = 7;
            Console.WriteLine((ShippingMethod)methodId);

            // Converting Enum method to String
            Console.WriteLine(method.ToString());

            //Reference Type
            var x = 10;
            var y= x;
            y++;
            Console.WriteLine(string.Format("x: {0}, y:{1}", x,y));

            var array1 = new int[5] { 1, 2, 3, 4, 5 };
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine(string.Format("array[0]: {0}, array2[0] : {1}", array1[0], array2[0]));

            // ValueType

            var number = 1;
            Increment(number);
            Console.WriteLine(number);

            var person = new Person() {Age = 20};
            MakeOld(person);
            Console.WriteLine(person.Age);


        }

        public static void Increment(int number)
        {
            number += 10; 
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }


        public enum ShippingMethod
        {
            RegularAirMail = 1,
            RegisteredAirMail = 2,
            Express = 3 
        }
    }

   
}
