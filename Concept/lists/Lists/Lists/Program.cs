internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Lists!");

        var numbers = new List<int>() { 1, 2, 3, 4, };
        numbers.Add(1);  // Adding an item at the end of the list
        numbers.AddRange(new int[3] {5,6,7});  // Adding range of list to the array

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        //IndexOf

        Console.WriteLine("Index fo 1: " + numbers.IndexOf(1)); // Gives the first index position of the list
        Console.WriteLine("Last Index fo 1: " + numbers.LastIndexOf(1)); // Gives the last index position of the list

        //Count
        Console.WriteLine("Count : " + numbers.Count); 

        //Remove: Need to use for loop if removing all instances of an item

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] == 1)
            {
                numbers.Remove(numbers[i]);
            }

        }

        foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

        // Clear

        numbers.Clear(); // Clears all items from the list.

    }



}