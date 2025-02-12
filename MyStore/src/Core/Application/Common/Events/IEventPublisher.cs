using MyStore.Shared.Events;

namespace MyStore.Application.Common.Events;
public interface IEventPublisher : ITransientService
{
    Task PublishAsync(IEvent @event);
}