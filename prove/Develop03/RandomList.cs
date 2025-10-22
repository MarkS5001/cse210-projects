class RandomList
{
    private Random _randomGenerator = new Random();
    private List<string> _listBank1 = new List<string>();
    private List<string> _listBank2 = new List<string>();
    private List<string> _wordsToSend = new List<string>();
    private int _wordToSend;
    public void GetList(List<string> list1, List<string> list2)
    {
        _listBank1 = list1;
        _listBank2 = list2;
    }
    public List<string> RandomComponent()
    {
        _wordToSend = _randomGenerator.Next(0, _listBank1.Count);
        _wordsToSend.Add(_listBank1[_wordToSend]);
        _wordsToSend.Add(_listBank2[_wordToSend]);
        return _wordsToSend;
    }
    public void MakeList(string newItem1, string newItem2)
    {
        _listBank1.Add(newItem1);
        _listBank2.Add(newItem2);
    }
}