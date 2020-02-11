namespace Management.Core
{
    public interface IService { }

    public abstract class ServiceBase<TDataConnection, TUnitOfWork> : IService
        where TUnitOfWork : IUnitOfWork
    {
        protected IRepositoryResourceFactory<TDataConnection, TUnitOfWork> RepositoryResourceFactory;

        protected IHelperResourceFactory HelperResourceFactory;

        public ServiceBase(IRepositoryResourceFactory<TDataConnection, TUnitOfWork> repositoryResourceFactory, IHelperResourceFactory helperResourceFactory = null)
        {
            RepositoryResourceFactory = repositoryResourceFactory;
            HelperResourceFactory = helperResourceFactory;
        }
    }
}
