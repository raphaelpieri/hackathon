namespace HCrossCutting
{
    using HInfrastructure;
    using HInfrastructure.Persistence.DataContext;
    using HSharedKernel;
    using HSharedKernel.Events;
    using Microsoft.Practices.Unity;
    public class DependencyRegister
    {
        // <summary>
        /// TransientLifetimeManager - Cada Resolve gera uma nova instância.
        /// HierarchicalLifetimeManager - Utiliza Singleton
        /// </summary>
        /// <param name="container"></param>
        public static void Register(UnityContainer container)
        {
            container.RegisterType<StoreDataContext, StoreDataContext>(new HierarchicalLifetimeManager());
            container.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager());
            //      container.RegisterType<IUserRepository, UserRepository>(new HierarchicalLifetimeManager());

            //     container.RegisterType<IUserApplicationService, UserApplicationService>(new HierarchicalLifetimeManager());

            container.RegisterType<IHandler<DomainNotification>, DomainNotificationHandler>(new HierarchicalLifetimeManager());
        }
    }
}
