class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;
    private Random _randomGenerator = new Random();
    public Scripture(string reference, string text)
    {
        // Split reference depending on if - is present (for multiple verses)
        Reference currentReference;
        if (reference.Contains('-'))
        {
            string[] slicedReference = reference.Split(' ', ':', '-');
            currentReference = new Reference(slicedReference[0], int.Parse(slicedReference[1]), int.Parse(slicedReference[2]), int.Parse(slicedReference[3]));
        }

        else
        {
            string[] slicedReference = reference.Split(' ', ':');
            currentReference = new Reference(slicedReference[0], int.Parse(slicedReference[1]), int.Parse(slicedReference[2]));
        }

        // Setter part of constructor
        _reference = currentReference;

        foreach (string word in text.Split(' ')) // Makes sure each word is by itself (has limitations)
        {
            Word currentWord = new Word(word);
            _words.Add(currentWord);
        }
    
    }
    public void Display() // Writes scripture to the console
    {
        Console.Clear();
        _reference.GetReference();

        foreach (Word word in _words)
        {
            word.Display();
        }
        Console.WriteLine();
    }
    public void HideWord() // Logic to hide words
    {
        int wordsToHide = _randomGenerator.Next(0, _words.Count / 4); // Sets the amount of words to hide (never more than a quarter of the total word count)
        for (int i = 0; i < wordsToHide; i++)
        {
            int number = _randomGenerator.Next(0, _words.Count);
            _words[number].HideWord();
        }
    }
    public string AllHidden() // Logic to see if all the words are hidden
    {
        int count = 0;
        foreach (Word word in _words)
        {
            count += word.Hidden();
        }
        if (_words.Count == count)
        {
            return "quit";
        }
        else
        {
            return "";
        }
    }
}