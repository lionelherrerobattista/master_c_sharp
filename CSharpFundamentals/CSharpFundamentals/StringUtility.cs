using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    public class StringUtility
    {

        public static string SummarizeText(string text, int maxLength = 20)
        {
            if (text.Length < maxLength)
                return text;

            //text.Substring(0, maxLength); // problem: cut words
            // To avoid cutting words: 
            var words = text.Split(' '); // to count words
            var totalCharacters = 0;
            var summaryWords = new List<string>(); // to store words

            foreach (var word in words)
            {
                summaryWords.Add(word); // add words to list

                totalCharacters += word.Length + 1; // + 1 because of whitespace

                if (totalCharacters > maxLength) // reached max amount of words
                    break;
            }

            return String.Join(" ", summaryWords) + "...";
        }
    }
}
