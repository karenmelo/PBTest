using PB.Core.Message;

namespace PB.Core.DomainObject;

public abstract class Entity
{
    public Guid Id { get; set; }

    protected Entity()
    {
        Id = Guid.NewGuid();
    }

    private List<Event> _events;
    public IReadOnlyCollection<Event> Notificacoes => _events?.AsReadOnly();

    public void AdicionarEvento(Event @event)
    {
        _events ??= new List<Event>();
        _events.Add(@event);
    }

    public void RemoverEvento(Event eventItem)
    {
        _events?.Remove(eventItem);
    }

    public void LimparEventos()
    {
        _events?.Clear();
    }

    #region Comparisons

    public override bool Equals(object obj)
    {
        var compareTo = obj as Entity;

        if (ReferenceEquals(this, compareTo)) return true;
        if (ReferenceEquals(null, compareTo)) return false;

        return Id.Equals(compareTo.Id);
    }

    public static bool operator ==(Entity a, Entity b)
    {
        if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
            return true;

        if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
            return false;

        return a.Equals(b);
    }

    public static bool operator !=(Entity a, Entity b)
    {
        return !(a == b);
    }

    public override int GetHashCode()
    {
        return (GetType().GetHashCode() * 907) + Id.GetHashCode();
    }

    public override string ToString()
    {
        return $"{GetType().Name} [Id={Id}]";
    }

    #endregion
}
