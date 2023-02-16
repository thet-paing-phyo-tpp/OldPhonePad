using OldPhonePad;

namespace TestOldPhonePad;

public class OldPhonePadTest
{
    [Theory]
    [InlineData("33#", "E")]
    [InlineData("227*#", "B")]
    [InlineData("4433555 555666#", "HELLO")]
    [InlineData("8 88777444666*664#", "TURING")]
    [InlineData("2222#", "S")]
    [InlineData("*22#", "B")]
    [InlineData("3388833777999844 44 44**444664#", "EVERYTHING")]
    public void Test(string input, string expectedOutput)
    {
        // Act
        string actualOutput = OldPhonePadClass.OldPhonePad(input);

        // Assert
        Assert.Equal(expectedOutput, actualOutput);
    }
}
