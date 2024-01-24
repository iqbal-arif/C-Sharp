
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
        }
    }
}
