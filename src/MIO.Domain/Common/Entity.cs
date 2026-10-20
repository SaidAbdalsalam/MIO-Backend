namespace MIO.Domain.Common;

public abstract class Entity
{
    public Guid Id { get; set; }

    private List<DomainEvent> _domainEvents = [];
    public IReadOnlyList<DomainEvent> DomainEvents => _domainEvents.AsReadOnly();

    protected Entity() { }

    public Entity(Guid id)
    {
        Id = id == Guid.Empty ? Guid.NewGuid() : id;
    }

    public bool AddDomainEvent(DomainEvent domainEvent)
    {
        if (domainEvent is null)
        {
            return false;
        }

        _domainEvents.Add(domainEvent);
        return true;
    }

    public bool RemoveDomainEvent(DomainEvent domainEvent)
    {
        if (domainEvent is null)
        {
            return false;
        }
        _domainEvents.Remove(domainEvent);
        return true;
    }

    public void ClearDomainEvents()
    {
        _domainEvents.Clear();
    }
}
