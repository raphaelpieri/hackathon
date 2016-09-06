namespace HSharedKernel
{
    using Events.Contracts;
    using System;
    using System.Collections.Generic;

    public interface IHandler<T> : IDisposable where T : IDomainEvent
    {
        void Handle(T args);
        IEnumerable<T> Notify();
        bool HasNotifications();
    }
}
