using OCP.Practice.Enums;

namespace OCP.Practice;

public class Product
{
    public string Name;
    public Color Color;
    public Size Size;
    public Product(string name, Color color, Size size)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentNullException(nameof(name));
        }
        Name = name;
        Color = color;
        Size = size;
    }
}
