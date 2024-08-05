﻿using MicroRabbit.Domain.Commands;
using MicroRabbit.Domain.Events;

namespace MicroRabbit.Domain.Bus
{
    public interface IEventBus
    {
        Task SendCommand<T>(T command) where T : Command;

        void Publish<T>(T evento) where T : Event;

        void Subscribe<T, TH>() where T : Event where TH : IEventHandler<T>;
    }
}
