namespace Collection_Demo
{
    internal class StringDemo
    {
        public static void StringDemoMain()
        {
            string original = "  Hello, C# World!  ";
            string searchString = "C#";
            string replaceString = "Programming";

            Console.WriteLine("Original String: \"" + original + "\"");

            // Length
            Console.WriteLine($"\n1. Length of string: {original.Length}");

            // Trim
            string trimmed = original.Trim();
            Console.WriteLine($"\n2. Trimmed string: \"{trimmed}\"");

            // ToUpper and ToLower
            Console.WriteLine($"\n3. Uppercase: {original.ToUpper()}");
            Console.WriteLine($"   Lowercase: {original.ToLower()}");

            // Contains
            Console.WriteLine($"\n4. Contains \"{searchString}\": {original.Contains(searchString)}");

            // StartsWith and EndsWith
            Console.WriteLine($"\n5. Starts with \"  Hello\": {original.StartsWith("  Hello")}");
            Console.WriteLine($"   Ends with \"World!  \": {original.EndsWith("World!  ")}");

            // IndexOf and LastIndexOf
            Console.WriteLine($"\n6. Index of \"{searchString}\": {original.IndexOf(searchString)}");
            Console.WriteLine($"   Last Index of 'o': {original.LastIndexOf('o')}");

            // Substring
            Console.WriteLine($"\n7. Substring (Start at 2, Length 5): \"{original.Substring(2, 5)}\"");

            // Replace
            string replaced = original.Replace(searchString, replaceString);
            Console.WriteLine($"\n8. Replacing \"{searchString}\" with \"{replaceString}\": \"{replaced}\"");

            // Split
            Console.WriteLine("\n9. Splitting by space:");
            string[] split = original.Split(' ');
            foreach (string part in split)
            {
                Console.WriteLine($"   \"{part}\"");
            }

            // Join
            string joined = string.Join(" | ", split);
            Console.WriteLine($"\n10. Joining split parts with \" | \": \"{joined}\"");

            // IsNullOrEmpty and IsNullOrWhiteSpace
            Console.WriteLine($"\n11. IsNullOrEmpty: {string.IsNullOrEmpty(original)}");
            Console.WriteLine($"    IsNullOrWhiteSpace: {string.IsNullOrWhiteSpace(original)}");

            // Compare
            Console.WriteLine($"\n12. Comparing \"Hello\" and \"hello\": {string.Compare("Hello", "hello", StringComparison.OrdinalIgnoreCase)}");

            // Equals
            Console.WriteLine($"\n13. Equals (case-insensitive): {original.Equals("  hello, c# world!  ", StringComparison.OrdinalIgnoreCase)}");

            // Concatenation
            Console.WriteLine($"\n14. Concatenation: {string.Concat("Hello", " ", "World!")}");

            // Format
            string formatted = string.Format("This is {0} and it costs {1:C}", "C#", 99.99);
            Console.WriteLine($"\n15. Formatted string: {formatted}");

            // Interpolation
            string interpolated = $"Interpolated string: {searchString} is awesome!";
            Console.WriteLine($"\n16. Interpolation: {interpolated}");

            // Empty and Null
            Console.WriteLine($"\n17. String.Empty: \"{string.Empty}\"");
            string nullString = null;
            Console.WriteLine($"    Null string: {nullString}");
        }
    }
}
