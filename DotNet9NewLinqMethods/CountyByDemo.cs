namespace DotNet9NewLinqMethods
{
    public static class CountyByDemo
    {
        public static void Execute()
        {
            string sourceText = """
                Lorem ipsum dolor sit amet, consectetur adipiscing elit.
                Sed non risus. Suspendisse lectus tortor, dignissim sit amet, 
                adipiscing nec, ultricies sed, dolor. Cras elementum ultrices amet diam.
            """;

            KeyValuePair<string, int> mostFrequentWord = sourceText
                .Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(word => word.ToLowerInvariant())
                .CountBy(word => word)
                .MaxBy(pair => pair.Value);

            Console.WriteLine(mostFrequentWord.Key);

            // Output:
            // amet
        }
    }
}