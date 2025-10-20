class Word
{
    private string _word;
    public Word(string word)
    {
        _word = word;
    }
    public void HideWord() // Logic for hiding the word
    {
        int length = _word.Length;
        _word = "_";
        
        for(int i = 1; i < length; i++)
        {
            _word = _word + "_";
        }
    }
    public void Display() // Writes word on the same line
    {
        Console.Write(_word);
        Console.Write(' ');
    }
}