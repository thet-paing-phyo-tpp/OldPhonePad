# OldPhonePad

# This function takes a string input and returns a string representation of the letters that would be generated from an old-style telephone keypad.

# Input
# The input should be a string of numbers and special characters, including:

# The numbers 2, 3, 4, 5, 6, 7, 8, and 9, which correspond to the letters on their respective keypads.
# The special character '#' which stops the function from processing any further characters.
# The special character '*' which removes the previous character.
# Spaces, which are ignored.
# Output
# The output is a string representation of the letters that correspond to the numbers and special characters in the input string. The output does not include the removed characters.

# Example
# Input: "4433555 555666#"
# Output: "HELLO"

# Usage
# To use this function, simply call OldPhonePad(input_string) and the output will be displayed in the console.

# Note
# This function uses a dictionary to map the numbers to their corresponding letters, and processes the input string character by character. If a number is repeated, the function counts the number of repetitions and outputs the corresponding letter from the appropriate position in the string for that keypad number.
