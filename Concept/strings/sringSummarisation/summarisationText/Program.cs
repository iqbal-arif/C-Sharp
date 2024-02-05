// See https://aka.ms/new-console-template for more information
Console.WriteLine("Text Summarisation!");

var sentences = "This is going to be a very extra ordinary perfecdt example of a very very very long paragrah.";
const int maxLength = 24;

if (sentences.Length < maxLength){
    Console.WriteLine(sentences);
}else{
    var words = sentences.Split(" ");
    var totalCharacters = 0;
    var summaryWords = new List<string>();

    foreach (var word in words){
        summaryWords.Add(word);
        // Console.WriteLine(word.Length);
        totalCharacters += word.Length;
        if (totalCharacters > maxLength){
            break;
        }
    }
    var summary = string.Join(" ", summaryWords) + "...";
    Console.WriteLine(summary);
}
