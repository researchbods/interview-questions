using System;
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
            
            Assert.AreEqual("scissors", instance.LongestCommonWord(
                new List<string> {
                    "love",
                    "wandering1",
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
        [Ignore("NotImplemented")]
        public void CanGetDistanceInMiles() {
            Assert.AreEqual(10.00, instance.DistanceInMiles(16.00));
        }

        [Test]
        [Ignore("NotImplemented")]
        public void CanGetDistanceInKilometers() {
            Assert.AreEqual(16.00, instance.DistanceInKm(10.00));
        }

        [Test]
        [Ignore("NotImplemented")]
        public void IsPalindrome() {
            var palindromes = new List<string> {

            };
            var invalid = new List<string> {

            };

            foreach (var word in palindromes) {
                Assert.True(instance.IsPalindrome(word));
            }

            foreach (var word in invalid) {
                Assert.False(instance.IsPalindrome(word));
            }
        }

        [Test]
        [Ignore("NotImplemented")]
        public void CanShuffle() {
            Assert.AreEqual(new List<string> { "two", "one" }, instance.Shuffle(new List<string> { "one", "two" }));
        }

        [Test]
        [Ignore("NotImplemented")]
        public void CanSort() {
            throw new NotImplementedException();
        }

        [Test]
        [Ignore("NotImplemented")]
        public void CanSumFibonacciNumbers() {
            Assert.AreEqual(4613732, instance.FibonacciSum());
        }

        [Test]
        [Ignore("NotImplemented")]
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