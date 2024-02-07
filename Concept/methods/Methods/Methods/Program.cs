using System.Security.Cryptography.X509Certificates;

internal partial class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Methods!\n");

        UseParams();
        UsePoints();
        UseOut();
    }        

        static void UseOut()
        {
            //int.Parse String to Int conversion
            try
            {
                var num = int.Parse("abc");
            }
            catch 
            {
                Console.WriteLine("Try Catch Conversion failed!");
            }

            int digit;
        //

        Console.WriteLine("Enter the string for conversion?");
        var result = int.TryParse(Console.ReadLine(), out digit);
            if (result) 
               Console.WriteLine(digit); 
            else
               Console.WriteLine("Conversion Failed!!"); 
            
        }

        static  void  UseParams()
        {
            var calculator = new Calcultor();
            Console.WriteLine(calculator.Add(1,2));
            Console.WriteLine(calculator.Add(1,2,3));
            Console.WriteLine(calculator.Add(1,2,3,4));
            Console.WriteLine(calculator.Add(new int[] {1,2,3,4,5}));
        }

        static void UsePoints()
        {

            try
            {
                //New Point Object

                var point = new Point(10, 20);
                //What is the difference of all the method with new and without it
                //point.Move(40, 60);
                //point.Move(new Point(40, 60));
                point.Move(null); //this is used to check for App error
                Console.WriteLine("Point is at ({0},{1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0},{1})", point.X, point.Y);

            }
            catch (Exception)
            {
                Console.WriteLine("Unexpected Error!!!");
            }
        }
}