import unittest
import questions

class UnitTests(unittest.TestCase):
	def test_can_extract_numbers(self):
		result = questions.extract_numbers(["123", 'hello', '234'])

		self.assertEqual(123, result[0])
		self.assertEqual(234, result[1])

	def test_can_get_longest_common_word(self):
		result = questions.longest_common_word(
			[
	         	'love',
	        	'wandering',
	         	'goofy',
	         	'sweet',
	         	'mean',
	         	'show',
	         	'fade',
	         	'scissors',
	         	'shoes',
	         	'gainful',
	         	'wind',
	         	'warn'
	     	],
			[
	        	'wacky',
	         	'fabulous',
	         	'arm',
	         	'rabbit',
	         	'force',
	         	'wandering',
	         	'scissors',
	         	'fair',
	        	'homely',
	         	'wiggly',
	         	'thankful',
	         	'ear'
	     	]
		)

		self.assertEqual('wandering', result)

	def test_can_get_distance_in_miles(self):
		self.assertEqual(questions.distance_in_miles(16), 10)

	def test_can_get_distance_in_km(self):
		self.assertEqual(questions.distance_in_km(10), 16)

	def test_can_determine_palindromes(self):
		palindromes = [
					'Anna', 
					'Hannah',
					'testset',
					'stats',
					'level',
					'radar',
					'rotor',
					'aibohphobia',
					'deified',
					'minim',
					'lemel',
					'solos',
					'kayak'
				]
		invalid = [
					'Palindrome',
					'wacky',
					'fabulous',
					'arm',
					'rabbit',
					'force',
					'wandering',
					'scissors',
					'fair',
					'homely',
					'wiggly',
					'thankful',
					'ear'
				 ]

		for p in palindromes:
			self.assertEqual(True, questions.isPalindrome(p))

		for i in invalid:
			self.assertEqual(False, questions.isPalindrome(i))