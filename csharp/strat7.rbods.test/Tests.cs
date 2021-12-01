using System;
using System.Linq;
using System.Collections.Generic;

using NUnit.Framework;

using strat7.rbods;

namespace strat7.rbods.test
{
    public class Tests {
        Questions instance = new Questions();

        [Test]
        public void CanExtractNumbers() {
            Assert.AreEqual(new List<int> {
                123,
                234
            }, instance.ExtractNumbers(new List<string> {
                "123",
                "hello",
                "234"
            }));

            Assert.AreEqual(new List<int> {}, instance.ExtractNumbers(new List<string> {
                "hello",
                "there"
            }));

            Assert.AreEqual(new List<int> {
                123,
                345
            }, instance.ExtractNumbers(new List<string> {
                "hello",
                "there",
                "123",
                "234.23",
                "345"
            }));
        }

        [Test]
        public void CanGetLongestCommonWord() {
            Assert.AreEqual("wandering", instance.LongestCommonWord(
                new List<string> {
                    "love",
                    "wandering",
                    "goofy",
                    "sweet",
                    "mean",
                    "show",
                    "fade",
                    "scissors",
                    "shoes",
                    "gainful",
                    "wind",
                    "warn"
                },
                new List<string> {
                    "wacky",
                    "fabulous",
                    "arm",
                    "rabbit",
                    "force",
                    "wandering",
                    "scissors",
                    "fair",
                    "homely",
                    "wiggly",
                    "thankful",
                    "ear"
                })
            );
        }

        [Test]
        public void CanGetDistanceInMiles() {
            Assert.AreEqual(10.00, instance.DistanceInMiles(16.00));
        }

        [Test]
        public void CanGetDistanceInKilometers() {
            Assert.AreEqual(16.00, instance.DistanceInKm(10.00));
        }

        [Test]
        public void IsPalindrome() {
            var palindromes = new List<string> {
                "anna", "kayak", "racecar"
            };
            var invalid = new List<string> {
                "bolton", "leeds", "manchester"
            };

            foreach (var word in palindromes) {
                Assert.True(instance.IsPalindrome(word));
            }

            foreach (var word in invalid) {
                Assert.False(instance.IsPalindrome(word));
            }
        }

        [Test]
        public void CanShuffle() {

            // This test isn't correct as shuffle brings back a random order that could be any order whereas the test is expecting a reverse order.
            // Assert.AreEqual(new List<string> { "two", "one" }, instance.Shuffle(new List<string> { "one", "two" }));

            // Arrange
            var list = new List<string> { "one", "two" };

            // Act
            var shuffled = instance.Shuffle(list);

            // Assert
            Assert.AreEqual(list.Distinct().Count(), shuffled.Distinct().Count());

        }

        [Test]
        public void CanSort() {
            Assert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, instance.Sort(new int[] { 3, 2, 4, 1, 5 }));
        }

        [Test]
        public void CanSumFibonacciNumbers() {
            Assert.AreEqual(4613732, instance.FibonacciSum());
        }

        [Test]
        public void CanGenerateListOfNumbers() {
            var list = instance.GenerateList();

            var current = 1;
            foreach (var num in list) {
                Assert.AreEqual(current, num);
                current++;
            }
        }
    }
}
