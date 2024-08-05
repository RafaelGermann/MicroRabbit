using MicroRabbit.Domain.Events;

namespace MicroRabbit.Domain.Bus
{
    public interface IEventHandler<in TEvent> : IEventHandler where TEvent : Event
    {
        Task Handle(TEvent evento);
    }

    public interface IEventHandler
    {
    }
}
