static string OldPhonePad(string input) {
    // Get The Index Of Asterisk
    int indexNo = input.IndexOf('*');

    // Remove The Character Before Asterisk by 1
    if (indexNo > 0)
    {
        input = input.Remove(indexNo - 1, 1);
    }

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

            // Interpolate String
            output += key_pad[input_chars[i]][count - 1];
        }
        // If There Is A Space, Continue
        else if (c == ' ')
        {
            continue;
        }
        // If There Is A #, Stop
        else if (c == '#')
        {
            break;
        }
    }

    return output;
}

// Test Scenarios
Console.WriteLine(OldPhonePad("33#"));
Console.WriteLine(OldPhonePad("227*#"));
Console.WriteLine(OldPhonePad("4433555 555666#"));
Console.WriteLine(OldPhonePad("8 88777444666*664#"));




