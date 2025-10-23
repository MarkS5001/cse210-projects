class ReadFile
{
    private List<string> _fileLines = new List<string>();
    private string _filename;
    public void GetFileContents()
    {
        Console.WriteLine("What is the filename? (Note to instructor, the file name is 'Scripture Bank.txt')");
        _filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(_filename);

        foreach (string line in lines)
        {
            _fileLines.Add(line);
        }
    }
    public List<string> SendFileLines()
    {
        return _fileLines;
    }
}