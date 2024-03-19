namespace DotNet9NewLinqMethods
{
    public static class IndexDemo
    {
        public static void Execute()
        {
            var users = new List<User>
            {
                new ("Ana"),
                new ("Camille"),
                new ("Bob"),
                new ("Jasmine")
            };

            foreach (var (index, user) in users.Index())
                Console.WriteLine($"Index {index} - {user.Name}");

            // Output:
            // Index 0 - Ana
            // Index 1 - Camille
            // Index 2 - Bob
            // Index 3 - Jasmine
        }

        private class User
        {
            public string Name { get; init; }

            public User(string name)
            {
                Name = name;
            }
        }
    }
}