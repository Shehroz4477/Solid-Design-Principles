namespace SRP.Practice;

public class Persistence
{
    public void Load(Journal entity, string fileName, bool isOverWrite = false)
    {
        if (isOverWrite || !File.Exists(fileName))
        {
            File.WriteAllText(fileName, entity.ToString());
        }
    }
}
