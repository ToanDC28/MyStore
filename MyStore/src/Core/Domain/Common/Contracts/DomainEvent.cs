using MyStore.Shared.Events;

namespace MyStore.Domain.Common.Contracts;
public abstract class DomainEvent : IEvent
{
    public DateTime TriggeredOn { get; protected set; } = DateTime.UtcNow;
}