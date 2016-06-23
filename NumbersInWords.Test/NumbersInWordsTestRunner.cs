using System;
using System.Collections.Generic;
using System.Reflection;

namespace NumbersInWords.Src
{
    public class NumbersInWordsTestRunner
    {

        public static void Main(string[] args)
        {
            var numbersToWords = new Dictionary<int, string> { { 0, "zero" }, { 1, "one" }, { 2, "two" }, { 3, "three" } };
            foreach (var tuple in numbersToWords)
            {
                RunParameterisedTests(tuple, for_number_we_should_print_word);
            }
            Console.ReadLine();
        }

        private static void RunParameterisedTests(KeyValuePair<int, string> inputs, Action<int, string> test)
        {
            Print(test.GetMethodInfo().Name.Replace("_", " ").
                Replace("number", inputs.Key.ToString()).
                Replace("word", inputs.Value));
            test(inputs.Key, inputs.Value);
        }

        private static void for_number_we_should_print_word(int input, string expected)
        {
            VerifyThat(expected, NumbersInWords.InWordsFor(input));
        }

        private static void Print(string message)
        {
            Console.WriteLine(message);
        }

        private static void VerifyThat(string expected, string actual)
        {
            if (expected.Equals(actual))
            {
                Console.WriteLine("Test has passed");
            }
            else
            {
                Console.WriteLine($"Test has failed: expected '{expected}' but was '{actual}'");
            }
        }
    }
}
