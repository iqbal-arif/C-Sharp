internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var numbers = new [] { 3, 7, 9, 2, 14, 6 };

        //Length
        Console.WriteLine("Length: " + numbers.Length);

        //IndexOF
       var index = Array.IndexOf(numbers, 9);
        Console.WriteLine("Index of 9: " + index);

        //Cleare()
        //Clearing integers means setting it to ZEOR
        //Clearing Boolean means setting Ture to False and False to TRUE.
        //Clearing String means clearing it to NULL

        Array.Clear(numbers, 0 , 2);
        Console.WriteLine("Effect of Clear()");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

        //Copy
        int[] another = new int[3];
        Array.Copy(numbers,another,3);

        Console.WriteLine("Effect of Copy()");
        foreach(var number in another)
        {
            Console.WriteLine(number);
        }


        // Sort()
        Array.Sort(numbers);
        Console.WriteLine("Effect of Sort()");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        //Reverse()
         Array.Reverse(numbers);
        Console.WriteLine("Effect of Sort()");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

    }
}