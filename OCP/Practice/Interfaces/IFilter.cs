namespace OCP.Practice.Interfaces;

public interface IFilter<Type>
{
    IEnumerable<Type> Filter(IEnumerable<Type> items, ISpecification<Type> specification);
}
