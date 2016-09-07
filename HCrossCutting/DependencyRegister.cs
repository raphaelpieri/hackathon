namespace HCrossCutting
{
    using HApplicationService;
    using HDomain.Repositories;
    using HDomain.Services;
    using HInfrastructure;
    using HInfrastructure.Persistence.DataContext;
    using HInfrastructure.Repositories;
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
            container.RegisterType<IPaiRepository, PaiRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IProfessorRepository, ProfessorRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IRepositoryTurmaMateria, RepositoryTurmaMateria>(new HierarchicalLifetimeManager());
            container.RegisterType<IAlunoRepository, AlunoRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<ITarefaRepository, TarefaRepository>(new HierarchicalLifetimeManager());
            

            container.RegisterType<IServiceProfessor, ServiceProfessor>(new HierarchicalLifetimeManager());
            container.RegisterType<IServicoPai, ServicoPai>(new HierarchicalLifetimeManager());

            container.RegisterType<IHandler<DomainNotification>, DomainNotificationHandler>(new HierarchicalLifetimeManager());
        }
    }
}
