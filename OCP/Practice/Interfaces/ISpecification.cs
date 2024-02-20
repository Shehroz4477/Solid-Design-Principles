namespace OCP.Practice.Interfaces;

public interface ISpecification<Type>
{
    bool IsSatisfied(Type item);
}
