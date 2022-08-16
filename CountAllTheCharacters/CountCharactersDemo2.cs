namespace CountAllTheCharacters
{
    internal class CountCharactersDemo2
    {
        public static void Run()
        {
            var characterCounts = new CharacterCount[58];
            while (true)
            {
                var text = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(text)) return;
                CountCharacters(text, characterCounts);
                ShowCounts(characterCounts);
            }
        }

        private static void CountCharacters(string text, CharacterCount[] characterCounts)
        {
            foreach (var character in text)
            {
                foreach (var characterCount in characterCounts)
                {
                    if (characterCount != null && characterCount.Character == character)
                    {
                        characterCount.Count++;
                    }
                }
            }
        }

        private static void ShowCounts(
            CharacterCount[] characterCounts)
        {
            foreach (var characterCount in characterCounts)
            {
                Console.WriteLine(characterCount.Character + " - " + characterCount.Count);
            }
        }
    }
}
