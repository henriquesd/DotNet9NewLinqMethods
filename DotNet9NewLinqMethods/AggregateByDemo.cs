namespace DotNet9NewLinqMethods
{
    public static class AggregateByDemo
    {
        public static void Execute()
        {
            var scoreEntries = new List<ScoreEntry>
            {
                new ("1", 50),
                new ("2", 20),
                new ("1", 40),
                new ("3", 10),
                new ("2", 30)
            };

            var aggregatedData = scoreEntries
                .AggregateBy(
                    keySelector: entry => entry.PlayerId,
                    seed: 0,
                    (totalScore, curr) => totalScore + curr.Score
                );

            foreach (var item in aggregatedData)
                Console.WriteLine(item);
            
            // Output:
            // [1, 90]
            // [2, 50]
            // [3, 10]
        }

        private class ScoreEntry
        {
            public string PlayerId { get; init; }
            public int Score { get; init; }

            public ScoreEntry(string playerId, int score)
            {
                PlayerId = playerId;
                Score = score;
            }
        }
    }
}