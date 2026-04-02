namespace StringExtensionsLibrary
{
    public static class StringExtensions
    {
        public static bool StartsWithUpperCase(this string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            return char.IsUpper(input[0]);
        }
    }
}
