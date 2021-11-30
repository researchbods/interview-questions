using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace strat7.rbods
{
    public class Questions
    {
        private const double KilometersPerMile = 1.6d;

        /// <summary>
        /// Given an enumerable of strings, attempt to parse each string and if
        /// it is an integer, add it to the returned enumerable.
        ///
        /// For example:
        ///
        /// ExtractNumbers(new List<string> { "123", "hello", "234" });
        ///
        /// ; would return:
        ///
        /// {
        ///   123,
        ///   234
        /// }
        /// </summary>
        /// <param name="source">An enumerable containing words</param>
        /// <returns></returns>
        public IEnumerable<int> ExtractNumbers(IEnumerable<string> source)
        {
            var listOfNumbers = new List<int>();
            foreach (var stringValue in source)
            {
                if (int.TryParse(stringValue, out var numberResult))
                {
                    listOfNumbers.Add(numberResult);
                }
            }

            return listOfNumbers;
        }

        /// <summary>
        /// Given two enumerables of strings, find the longest common word.
        ///
        /// For example:
        ///
        /// LongestCommonWord(
        ///     new List<string> {
        ///         "love",
        ///         "wandering",
        ///         "goofy",
        ///         "sweet",
        ///         "mean",
        ///         "show",
        ///         "fade",
        ///         "scissors",
        ///         "shoes",
        ///         "gainful",
        ///         "wind",
        ///         "warn"
        ///     },
        ///     new List<string> {
        ///         "wacky",
        ///         "fabulous",
        ///         "arm",
        ///         "rabbit",
        ///         "force",
        ///         "wandering",
        ///         "scissors",
        ///         "fair",
        ///         "homely",
        ///         "wiggly",
        ///         "thankful",
        ///         "ear"
        ///     }
        /// );
        ///
        /// ; would return "wandering" as the longest common word.
        /// </summary>
        /// <param name="first">First list of words</param>
        /// <param name="second">Second list of words</param>
        /// <returns></returns>
        public string LongestCommonWord(IEnumerable<string> first, IEnumerable<string> second)
        {
            return first.Intersect(second).OrderByDescending(x => x.Length).FirstOrDefault();
        }

        /// <summary>
        /// Write a method that converts kilometers to miles, given that there are
        /// 1.6 kilometers per mile.
        ///
        /// For example:
        ///
        /// DistanceInMiles(16.00);
        ///
        /// ; would return 10.00;
        /// </summary>
        /// <param name="km">distance in kilometers</param>
        /// <returns></returns>
        public double DistanceInMiles(double km)
        {
            return km / KilometersPerMile;
        }

        /// <summary>
        /// Write a method that converts miles to kilometers, give that there are
        /// 1.6 kilometers per mile.
        ///
        /// For example:
        ///
        /// DistanceInKm(10.00);
        ///
        /// ; would return 16.00;
        /// </summary>
        /// <param name="miles">distance in miles</param>
        /// <returns></returns>
        public double DistanceInKm(double miles)
        {
            return miles * KilometersPerMile;
        }

        /// <summary>
        /// Write a method that returns true if the word is a palindrome, false if
        /// it is not.
        ///
        /// For example:
        ///
        /// IsPalindrome("bolton");
        ///
        /// ; would return false, and:
        ///
        /// IsPalindrome("Anna");
        ///
        /// ; would return true.
        ///
        /// Also complete the related test case for this method.
        /// </summary>
        /// <param name="word">The word to check</param>
        /// <returns></returns>
        public bool IsPalindrome(string word)
        {
            var lettersArray = word.ToCharArray();
            Array.Reverse(lettersArray);
            var reverseWord = new string(lettersArray);
            return word.Equals(reverseWord, StringComparison.InvariantCultureIgnoreCase);
        }

        /// <summary>
        /// Write a method that takes an enumerable list of objects and shuffles
        /// them into a different order.
        ///
        /// For example:
        ///
        /// Shuffle(new List<string>{ "one", "two" });
        ///
        /// ; would return:
        ///
        /// {
        ///   "two",
        ///   "one"
        /// }
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public IEnumerable<object> Shuffle(IEnumerable<object> source)
        {
            var arrayShuffled = false;
            object[] sourceArray;

            do{
                sourceArray = source.ToArray();
                var random = new Random();
                for (var i = sourceArray.Length - 1; i > 0; i--)
                {
                    var randomIndex = random.Next(i + 1);
                    var tempValue = sourceArray[i];
                    sourceArray[i] = sourceArray[randomIndex];
                    sourceArray[randomIndex] = tempValue;
                }

                arrayShuffled = IsShuffled(sourceArray, source.ToArray());

                if (!arrayShuffled)
                {
                    sourceArray = null;
                }

            }while(!arrayShuffled);

            return sourceArray;
        }

        private bool IsShuffled(object[] sourceArray, object[] shuffledArray)
        {

            var comparer = EqualityComparer<object>.Default;
            for (var i = 0; i < sourceArray.Length; i++)
            {
                if (!comparer.Equals(sourceArray[i], shuffledArray[i]))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Write a method that sorts an array of integers into ascending
        /// order - do not use any built in sorting mechanisms or frameworks.
        ///
        /// Complete the test for this method.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public int[] Sort(int[] source)
        {
            for (var i = 0; i < source.Length; i++)
            {
                for (var j = i + 1; j < source.Length; j++)
                {
                    if (source[i] <= source[j]) continue;

                    var tempValue = source[i];
                    source[i] = source[j];
                    source[j] = tempValue;
                }
            }

            return source;
        }

        /// <summary>
        /// Each new term in the Fibonacci sequence is generated by adding the
        /// previous two terms. By starting with 1 and 2, the first 10 terms will be:
        ///
        /// 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
        ///
        /// By considering the terms in the Fibonacci sequence whose values do
        /// not exceed four million, find the sum of the even-valued terms.
        /// </summary>
        /// <returns></returns>
        public int FibonacciSum()
        {
            var fibonacciSeries = new List<int>(){ 1, 2 };
            while (fibonacciSeries.LastOrDefault() < 4000000)
            {
                var currentCount = fibonacciSeries.Count();
                fibonacciSeries.Add(fibonacciSeries.ElementAt(currentCount - 2) + fibonacciSeries.ElementAt(currentCount - 1));
            }

            return fibonacciSeries.Where(x => x % 2 == 0).Sum();
        }

        /// <summary>
        /// Generate a list of integers from 1 to 100.
        ///
        /// This method is currently broken, fix it so that the tests pass.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<int> GenerateList()
        {
            var listNumbers = new List<int>();

            for (var i = 1; i <= 100; i++)
            {
                listNumbers.Add(i);
            }

            return listNumbers;
        }
    }
}
