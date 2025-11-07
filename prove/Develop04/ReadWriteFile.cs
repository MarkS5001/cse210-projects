class ReadWriteFile
{
    private List<string> _fileLines = new List<string>();
    private string _fileName;
    public ReadWriteFile(string file)
    {
        FileName(file);
        GetFileContents();
    }
    public ReadWriteFile()
    {
        
    }
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
        _fileLines.Clear();
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
    public void SaveContents(string name, int duration)
    {
        _fileLines.Add($"{DateTime.Now}~{name}~{duration}");
    }
    public void ExportContents()
    {
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach (string line in _fileLines)
            {
                outputFile.WriteLine(line);
            }
        }
    }
    public void DisplayFileContents()
    {
        foreach (string line in _fileLines)
        {
            Console.WriteLine(line);
        }
        Console.WriteLine();
        Console.WriteLine("Press enter to quit");
        Console.ReadLine();
    }
}