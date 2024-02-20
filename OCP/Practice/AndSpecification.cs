using OCP.Practice.Interfaces;

namespace OCP.Practice;

public class AndSpecification<Type> : ISpecification<Type>
{
    ISpecification<Type> _first, _second;

    public AndSpecification(ISpecification<Type> first, ISpecification<Type> second)
    {
        _first = first?? throw new ArgumentNullException(nameof(first));
        _second = second?? throw new ArgumentNullException(nameof(second));
    }

    public bool IsSatisfied(Type item)
    {
        return (_first.IsSatisfied(item) && _second.IsSatisfied(item));
    }
}
