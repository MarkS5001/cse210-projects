class Reference
{
    private string _book;
    private int _chapter;
    private int _firstVerse;
    private int _lastVerse = 0;

    // Two reference constructors for if it's a multi-verse scripture
    public Reference(string book, int chapter, int firstVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
    }
    public Reference(string book, int chapter, int firstVerse, int lastVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _lastVerse = lastVerse;
    }
    public void GetReference() // Two options if multi-verse scripture
    {
        if (_lastVerse == 0)
        {
            Console.WriteLine($"{_book} {_chapter}:{_firstVerse}");
        }
        else
        {
            Console.WriteLine($"{_book} {_chapter}:{_firstVerse}-{_lastVerse}");
        }
    }
}