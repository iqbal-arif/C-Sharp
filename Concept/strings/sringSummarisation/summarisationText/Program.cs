using summarisationText;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Text Summarisation!");

        var sentences = "This is going to be a very extra ordinary perfecdt example of a very very very long paragrah.";

        var summary = StringUtility.SummerizeText(sentences,25);
        Console.WriteLine(summary);

    }
    
}