namespace CountAllTheCharacters
{
    internal class CountCharactersDemo
    {
        public static void Run()
        {
            var maxCharacterNumber = 250;
            var characterCounts = new int[maxCharacterNumber];
            while (true)
            {
                var text = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(text)) return;
                CountCharacters(text, characterCounts);
                ShowCounts(maxCharacterNumber, characterCounts);
            }
        }

        private static void ShowCounts(int maxCharacterNumber, int[] characterCounts)
        {
            for (var i = 0; i < maxCharacterNumber; i++)
            {
                if (characterCounts[i] > 0)
                {
                    var character = (char)i;
                    Console.WriteLine(character + " - " + characterCounts[i]);
                }
            }
        }

        private static void CountCharacters(string text, int[] characterCounts)
        {
            foreach (var character in text)
            {
                var characterAsNumber = (int)character;
                characterCounts[characterAsNumber]++;
            }
        }

    }
}
