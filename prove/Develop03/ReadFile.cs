class ReadFile
{
    private List<string> _fileLines = new List<string>();
    private string _fileName;
    public void FileName()
    {
        Console.WriteLine("What is the filename?");
        _fileName = Console.ReadLine();
    }
    public void FileName(string filename)
    {
        _fileName = filename;
    }
    public void GetFileContents()
    {
        string[] lines = System.IO.File.ReadAllLines(_fileName);

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