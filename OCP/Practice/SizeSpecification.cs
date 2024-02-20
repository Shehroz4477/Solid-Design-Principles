using OCP.Practice.Enums;
using OCP.Practice.Interfaces;

namespace OCP.Practice;

public class SizeSpecification: ISpecification<Product>
{
    private readonly Size _size;

    public SizeSpecification(Size size)
    {
        _size = size;
    }

    public bool IsSatisfied(Product item)
    {
        return (_size == item.Size);
    }
}
