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
def extract_numbers(source):
	extracted_numbers = []
	for txt in source:
		if txt.isnumeric():
			extracted_numbers.append(int(txt))
	return extracted_numbers


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
	longest_common = ""
	first.sort(key=len)
	second.sort(key=len)
	for word in first:
		for second_word in second:
			if word == second_word and len(word) > len(longest_common):
				longest_common = word
	return longest_common


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
	backwards_text = word[::-1]
	return word.lower() == backwards_text.lower()
