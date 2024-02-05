using System.Text;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("String Builder!\n");

        var builder = new StringBuilder();

        builder.Append('_', 10);
        builder.AppendLine(); // Adds a new empty line
        builder.Append("Header");
        builder.AppendLine(); // Adds a new empty line
        builder.Append('_', 10);

        builder.Replace('_', '*');
        builder.Remove(0, 10); // Removes the first entity of the builder string

        builder.Insert(0,new string('+', 5));  // Insert goes to the begining of the first builder string entity.


        Console.WriteLine(builder);


        var builderTwo = new System.Text.StringBuilder("This is Another Example of StringBuilder Class");

        builderTwo
            .Append('*', 7)
            .AppendLine()
            .Append("StringBuliderTwo")
            .AppendLine()
            .Append('*', 7)
            .Remove(10, 3)
            .Insert(5, new string('/', 7))
            .Replace('/', '_',7,3);



        Console.WriteLine(builderTwo);


    }
}