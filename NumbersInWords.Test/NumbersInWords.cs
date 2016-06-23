using System.Collections.Generic;

namespace NumbersInWords.Src
{
    public class NumbersInWords
    {
        public static string InWordsFor(int number)
        {
            var numbersToWords = new Dictionary<int, string> { { 0, "zero" }, { 1, "one" }, { 2, "two" }, { 3, "three" } };
            return numbersToWords[number];
        }
    }
}