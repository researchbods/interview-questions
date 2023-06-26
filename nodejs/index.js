/// Given an enumerable of strings, attempt to parse each string and if
/// it is an integer, add it to the returned enumerable.
///
/// For example:
///
/// extractNumbers(["123", "hello", "234"]);
///
/// ; would return:
///
/// [
///   123,
///   234
/// ]
///
const extractNumbers = (source) => {

	/// results list.
	let results = Array();

	/// iterate source and test for numbers.
	source.forEach(element => {
		let e = parseFloat(element);
		if (!isNaN(e)) {
			results.push(e);
		}
	});

	return results;
};

/// Given two enumerables of strings, find the longest common word.
///
/// For example:
///
/// longestCommonWord(
///     [
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
///     ],
///     [
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
///     ]
/// );
///
/// ; would return "wandering" as the longest common word.
const longestCommonWord = (first, second) => {

	/// longest word result.
	let result = '';

	/// iterate the first list.
	first.forEach(e => {
		if (e.length > result.length) {
			result = e;
		}
	});

	/// iterate the second list.
	second.forEach(e => {
		if (e.length > result.length) {
			result = e;
		}
	});

	return result;
};

/// Write a method that converts kilometers to miles, given that there are
/// 1.6 kilometers per mile.
///
/// For example:
///
/// distanceInMiles(16);
///
/// ; would return 10;
const distanceInMiles = (kilometers) => {

	/// set the ratio.
	let ratio = 1.6;

	/// return the conversion.
	return kilometers / ratio;
};

/// Write a method that converts miles to kilometers, give that there are
/// 1.6 kilometers per mile.
///
/// For example:
///
/// distanceInKm(10);
///
/// ; would return 16;
const distanceInKm = (miles) => {

	/// set the ratio.
	let ratio = 1.6;

	/// return the conversion.
	return miles * ratio;
};

/// Write a method that returns true if the word is a palindrome, false if
/// it is not.
///
/// For example:
///
/// isPalindrome("bolton");
///
/// ; would return false, and:
///
/// isPalindrome("Anna");
///
/// ; would return true.
///
/// Also complete the related test case for this method.
const isPalindrome = (word) => {

	/// reverse the word.
	let reversed = word.split("").reverse().join("");

	/// return either palindrome or not.
	return word === reversed;
};

/// Generate a list of integers from 1 to 100.
///
/// This method is currently broken, fix it so that the tests pass, without
/// removing the function call that inserts the number.
const generateList = () => {
	var list = new Array();
	var funcs  = new Array();
	for (var i = 1; i <= 100; i++) {
		funcs.push(function(){
			list.push(i);
		});
	};

	/// removed the callback.
	/// funcs.map((f) => f());

	return list;
};

module.exports = {
	extractNumbers 		: extractNumbers,
	longestCommonWord 	: longestCommonWord,
	distanceInMiles 	: distanceInMiles,
	distanceInKm 		: distanceInKm,
	isPalindrome 		: isPalindrome,
	generateList 		: generateList
};
