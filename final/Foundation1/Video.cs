class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public void AddComment(string name, string text)
    {
        Comment currentComment = new Comment(name, text);
        _comments.Add(currentComment);
    }
    public int NumberOfComments()
    {
        return _comments.Count;
    }
    public void Display()
    {
        Console.WriteLine("-------------------------");
        Console.WriteLine($"Title: {_title}\nAuthor: {_author}\nLength: {_length}\nNumber of Comments: {NumberOfComments()}\n");
        foreach (Comment currentComment in _comments)
        {
            Console.WriteLine(currentComment.Display());
        }
        Console.WriteLine("-------------------------");
    }
}