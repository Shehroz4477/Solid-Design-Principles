using OCP.Practice.Enums;
using OCP.Practice.Interfaces;
namespace OCP.Practice;

public class ColorSpecification : ISpecification<Product>
{
    private Color _color;
    public ColorSpecification(Color color)
    {
        _color = color;
    }
    public bool IsSatisfied(Product item)
    {
        return (item.Color == _color);
    }
}
