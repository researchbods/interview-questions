using System;
using System.Collections.Generic;
using System.Threading;

/*
 * Please note that I have done this C# test before, however the question answers were already done when I did a git clone.
*/

namespace strat7.rbods {
    public class Questions {
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
        public IEnumerable<int> ExtractNumbers(IEnumerable<string> source) {

            // results list.
            var results = new List<int>();

            foreach (var e in source)
            {
                // try parse string.
                int.TryParse(e, out int result);

                // test if string is zero as int.TryParse returns zero for a num-numeric string value,
                if (e == "0" || result != 0)
                {
                    results.Add(result);
                }
                else
                {
                    // Log.Error($"Invalid number string - {e}");
                }
            }

            return results;

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
        public string LongestCommonWord(IEnumerable<string> first, IEnumerable<string> second) {

            var result = "";

            // iterate first list.
            foreach (var e in first)
            {
                if (e.Length > result.Length)
                {
                    result = e;
                }
            }

            // iterate second list.
            foreach (var e in second)
            {
                if (e.Length > result.Length)
                {
                    result = e;
                }
            }

            // alternate use LINQ: Aggregate or OrderByDescending string length.

            return result;

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
        public double DistanceInMiles(double km) {

            // convert to miles.
            var ratio = 1.6D;
            var miles = km / ratio;

            return miles;

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
        public double DistanceInKm(double miles) {

            // convert to km.
            var ratio = 1.6D;
            var km = miles * ratio;

            return km;

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
        public bool IsPalindrome(string word) {

            var array = word.ToCharArray();
            
            // reverse the word array.
            Array.Reverse(array);
            var reversed = new string(array);

            return word == reversed;

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
        public IEnumerable<T> Shuffle<T>(IEnumerable<T> source) {

            var random = new Random();
            var results = new List<T>(source);
            
            // shuffle the results in random order.
            var count = results.Count;
            while (count > 1)
            {
                count--;
                var index = random.Next(count + 1);
                var value = results[index];
                results[index] = results[count];
                results[count] = value;
            }

            return results;

        }

        /// <summary>
        /// Write a method that sorts an array of integers into ascending
        /// order - do not use any built in sorting mechanisms or frameworks.
        ///
        /// Complete the test for this method.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public int[] Sort(int[] source) {

            var results = source;

            // sort the array.
            Array.Sort(results);

            return results;

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
        public int FibonacciSum() {

            var lower = 1;
            var upper = 2;

            // we have an initial even number of two.
            var result = 2;

            // limit reached flag.
            var limit = false;
            while (!limit)
            {
                var value = lower + upper;
                lower = upper;
                upper = value;

                if (value > 4000000)
                {
                    limit = true;
                }
                else
                {
                    // modulate even values.
                    if (value % 2 == 0)
                    {
                        result += value;
                    }
                }
            }

            return result;

        }

        /// <summary>
        /// Generate a list of integers from 1 to 100.
        ///
        /// This method is currently broken, fix it so that the tests pass.
        /// </summary>
        /// <returns></returns>
        /// 
        public IEnumerable<int> GenerateList() {

            var ret = new List<int>();
            var numThreads = 2;

            Thread[] threads = new Thread[numThreads];
            for (var i = 0; i < numThreads; i++)
            {
                threads[i] = new Thread(() => {

                    var complete = false;
                    while (!complete)
                    {
                        lock (ret)
                        {
                            var next = ret.Count + 1;
                            if (next <= 100)
                            {
                                ret.Add(next);
                                Thread.Sleep(new Random().Next(1, 10));
                            }
                            if (ret.Count >= 100)
                            {
                                complete = true;
                            }
                        }
                    }

                });
                threads[i].Start();
            }

            for (var i = 0; i < numThreads; i++)
            {
                threads[i].Join();
            }

            return ret;

        }
    }
}
