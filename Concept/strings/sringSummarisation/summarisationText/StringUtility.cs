using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace summarisationText
{
    public class StringUtility
    {
        public static string SummerizeText(string text, int maxLength = 15)
        {
            if (text.Length < maxLength)
            {
                return text;
            }
            else
            {
                var words = text.Split(" ");
                var totalCharacters = 0;
                var summaryWords = new List<string>();

                foreach (var word in words)
                {
                    summaryWords.Add(word);
                    // Console.WriteLine(word.Length);
                    totalCharacters += word.Length;
                    if (totalCharacters > maxLength) { break; }
                }
                return String.Join(" ", summaryWords) + "...";
            }

        }
    }
}
