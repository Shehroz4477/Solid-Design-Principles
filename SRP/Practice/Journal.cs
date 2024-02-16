namespace SRP.Practice;

public class Journal
{
    private readonly List<string> _entries = new List<string>();
    public static int count = 0;

    public int AddEntry(string entry)
    {
        _entries.Add($"{++count}:{entry}");
        return count; // momento
    }

    public void RemoveEntry(int index)
    {
        _entries.RemoveAt(index);
    }

    public override string ToString()
    {
        return string.Join(Environment.NewLine, _entries);
    }

    public void Save(string fileName)
    {
        File.WriteAllText(fileName, ToString);
    }

    public static Journal Load(string fileName)
    {
        //TODO
    }

    public void Load(Uri uri)
    {
        //TODO
    }
}
