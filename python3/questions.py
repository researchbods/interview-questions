# Given an enumerable of strings, attempt to parse each string and if
# it is an integer, add it to the returned enumerable.
#
# For example:
#
# extract_numbers(["123", "hello", "234"]);
#
# ; would return:
#
# [
#   123,
#   234
# ]
#
from nis import cat


def extract_numbers(source):
	ints = []
	for entry in source:
		try:
			ints.append(int(entry))
		except:
			pass

	return ints

# Given two enumerables of strings, find the longest common word.
#
# For example:
#
# longest_common_word(
#     [
#         "love",
#         "wandering",
#         "goofy",
#         "sweet",
#         "mean",
#         "show",
#         "fade",
#         "scissors",
#         "shoes",
#         "gainful",
#         "wind",
#         "warn"
#     ],
#     [
#         "wacky",
#         "fabulous",
#         "arm",
#         "rabbit",
#         "force",
#         "wandering",
#         "scissors",
#         "fair",
#         "homely",
#         "wiggly",
#         "thankful",
#         "ear"
#     ]
# );
#
# ; would return "wandering" as the longest common word.
def longest_common_word(first, second):
	return max(list(set(first).intersection(second)), key=len)

# Write a function that converts kilometers to miles, given that there are
# 1.6 kilometers per mile.
#
# For example:
#
# distance_in_miles(16);
#
# ; would return 10;
def distance_in_miles(kilometers):
	return kilometers / 1.6

# Write a function that converts miles to kilometers, give that there are
# 1.6 kilometers per mile.
#
# For example:
#
# distance_in_km(10);
#
# ; would return 16;
def distance_in_km(miles):
	return miles * 1.6

# Write a function that returns true if the word is a palindrome, false if
# it is not.
#
# For example:
#
# isPalindrome("bolton");
#
# ; would return False, and:
#
# isPalindrome("Anna");
#
# ; would return True.
#
# Also complete the related test case for this method.
def isPalindrome(word):
	return word == word[::-1]