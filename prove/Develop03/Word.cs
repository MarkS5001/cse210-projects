class Word
{
    private string _word;
    private bool _hidden;
    public Word(string word)
    {
        _word = word;
    }
    public void HideWord() // Logic for hiding the word
    {
        if (_hidden == false)
        {
            int length = _word.Length;
            _word = "_"; // Clears what _word previously was

            for (int i = 1; i < length; i++) // Put underscores for each letter
            {
                _word = _word + "_";
            }
            _hidden = true;
        }
    }
    public void Display() // Writes _word on the same line
    {
        Console.Write(_word);
        Console.Write(' ');
    }
    public int Hidden() // Logic to tell if _word is currently hidden
    {
        if (_hidden == true)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
}