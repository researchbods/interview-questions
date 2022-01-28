using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace strat7.rbods
{
    public class Questions
    {
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
            List<int> parsedNumbers = new List<int>();

            foreach (string s in source)
            {
                if (int.TryParse(s, out int number))
                {
                    parsedNumbers.Add(number);
                }
            }

            return parsedNumbers;
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
            return first.Intersect(second).OrderByDescending(s => s.Length).FirstOrDefault();
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
            return km / 1.6;
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
            return miles * 1.6;
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
            word = word.ToLower();
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
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
            List<object> objects = source.ToList();
            Random rnd = new Random();

            for (int i = 0; i < objects.Count(); i++)
            {
                int random = rnd.Next(1, objects.Count());
                object temp = objects[i];
                objects[i] = objects[random];
                objects[random] = temp;
            }

            return objects;
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
            //Plz note, because the method returns an int array, I understood this to mean the sorting should not be 
            //done in place i.e. the passed in array should not be modified. Thus creating a copy of the source array.
            //There are many algorithms out there for sorting such as quick sort and merge sort which are much faster
            //and more complicated than what I have used here. Since the question did not ask for the most efficient 
            //algorithm, I have gone with the below algorithm for its simplicty.
            int[] sorted = new int[source.Length];
            Array.Copy(source, sorted, source.Length);
            bool stopLoop = false;
            int i, temp;

            while (!stopLoop)
            {
                stopLoop = true;

                for (i = 0; i < sorted.Length - 1; i++)
                {
                    if (sorted[i] > sorted[i + 1])
                    {
                        temp = sorted[i];
                        sorted[i] = sorted[i + 1];
                        sorted[i + 1] = temp;
                        stopLoop = false;
                    }
                }
            }

            return sorted;
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
            int sum = 0, prev = 0, current = 1, next;

            while (true)
            {
                next = prev + current;
                prev = current;
                current = next;

                if (next >= 4_000_000)
                {
                    break;
                }
                else if (next % 2 == 0)
                {
                    sum += next;
                }
            }

            return sum;
        }

        /// <summary>
        /// Generate a list of integers from 1 to 100.
        ///
        /// This method is currently broken, fix it so that the tests pass.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<int> GenerateList()
        {
            var ret = new ConcurrentDictionary<int, byte>();
            var numThreads = 2;

            Thread[] threads = new Thread[numThreads];
            for (var i = 0; i < numThreads; i++)
            {
                threads[i] = new Thread(() =>
                {
                    var complete = false;
                    while (!complete)
                    {
                        var next = ret.Count + 1;
                        Thread.Sleep(new Random().Next(1, 10));

                        if (next <= 100)
                        {
                            ret[next] = 0;
                        }

                        if (ret.Count >= 100)
                        {
                            complete = true;
                        }
                    }
                });
                threads[i].Start();
            }

            for (var i = 0; i < numThreads; i++)
            {
                threads[i].Join();
            }

            return ret.Keys;
        }
    }
}
