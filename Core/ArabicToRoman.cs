namespace Core
{
    public static class ArabicToRoman
    {
        static private readonly Dictionary<int, string> numberMapping = new()
        {
            { 1, "I" },
            { 4, "IV" },
            { 5, "V" },
            { 9, "IX" },
            { 10, "X" },
            { 40, "XL" },
            { 50, "L" },
            { 90, "XC" },
            { 100, "C" },
            { 400, "CD" },
            { 500, "D" },
            { 900, "CM" },
            { 1000, "M" }
        };

        public static string Convert(int original)
        {
            if (original < 1 || original > 2000)
            {
                throw new ArgumentException("The number is out of the 0-2000 interval.");
            }
            string result = "";

            foreach(KeyValuePair<int, string> element in numberMapping.Reverse())
            {
                while (original >= element.Key)
                {
                    result += element.Value;
                    original -= element.Key;
                }
            }

            return result;
        }
    }
}