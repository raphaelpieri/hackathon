namespace HInfrastructure
{
    using System;
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
