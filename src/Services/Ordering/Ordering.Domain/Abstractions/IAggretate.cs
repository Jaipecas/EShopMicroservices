
namespace Ordering.Domain.Abstractions;

public interface IAggregate<T>: IAggretate, IEntity<T>
{

}

public interface IAggretate : IEntity
{
    IReadOnlyList<IDomainEvent> DomainEvents { get; }
    IDomainEvent[] ClearDomainEvents();
}

