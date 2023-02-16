using System;

namespace OldPhonePad
{
    public static class OldPhonePadClass
    {
        public static string OldPhonePad(string input)
        {
            // Map The Number And Characters
            Dictionary<char, string> key_pad = new()
            {
                { '2', "ABC" },
                { '3', "DEF" },
                { '4', "GHI" },
                { '5', "JKL" },
                { '6', "MNO" },
                { '7', "PQRS" },
                { '8', "TUV" },
                { '9', "WXYZ" }
            };

            string output = "";

            // Turn Finalized Inputs Into Char Array
            char[] input_chars = input.ToCharArray();

            for (int i = 0; i < input_chars.Length; i++)
            {
                // Remove * at the beginning of the input
                while (input_chars[i] == input_chars[0] && input_chars[0] == '*')
                {
                    char[] new_input_chars = new char[input_chars.Length - 1];
                    int indexToRemove = Array.IndexOf(input_chars, input_chars[i]);

                    Array.Copy(input_chars, 0, new_input_chars, 0, indexToRemove);
                    Array.Copy(input_chars, indexToRemove + 1, new_input_chars, indexToRemove, input_chars.Length - indexToRemove - 1);

                    input_chars = new_input_chars;
                }
            }

            for (int i = 0; i < input_chars.Length; i++)
            {
                char c = input_chars[i];

                // Check If The Char Array Contain Numeric From key_pad Dictionary
                if (key_pad.ContainsKey(c))
                {
                    int count = 1;

                    // Check If Current And Next Array Has Same Repetitive Value
                    while (input_chars[i] == input_chars[i + 1])
                    {
                        i++;
                        count++;

                        if (i + 1 == input_chars.Length)
                            break;
                    }

                    if (key_pad[input_chars[i]].Length < count)
                        // If Numbers are pressed more than they are supposed to:
                        switch (c)
                        {
                            case '2':
                                output += "S";
                                break;
                            case '8':
                                output += "T";
                                break;
                            case '3':
                            case '4':
                            case '5':
                            case '6':
                            case '7':
                            case '9':
                                output += key_pad[input_chars[i]][key_pad[input_chars[i]].Length - 1];
                                break;
                        }
                    else
                        output += key_pad[input_chars[i]][count - 1];
                }
                // If There Is A Space, Continue
                else if (c == ' ')
                {
                    continue;
                }
                else if (c == '*')
                {
                    output = output.Remove(output.Length - 1);
                }
                // If There Is A #, Stop
                else if (c == '#')
                {
                    break;
                }
            }

            return output;
        }

    }
}

