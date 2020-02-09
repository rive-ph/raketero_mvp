using System;
using System.Collections.Generic;

namespace Management.Core
{
    public interface IRepositoryResourceFactory<TDataConnection, TUnitOfWork>
        where TUnitOfWork : IUnitOfWork
    {
        TUnitOfWork GetUnitOfWorkInstance();

        T GetInstance<T>() where T : IRepository;

    }

    public abstract class RepositoryResourceFactoryBase<TDataConnection, TUnitOfWork> : IRepositoryResourceFactory<TDataConnection, TUnitOfWork>
        where TUnitOfWork : IUnitOfWork
    {
        // Primary Database Connection
        protected TDataConnection DataConnection;

        // Repositories 
        protected IDictionary<string, Type> Repositories = new Dictionary<string, Type>();

        public RepositoryResourceFactoryBase(TDataConnection connection)
        {
            DataConnection = connection;
        }

        public TUnitOfWork GetUnitOfWorkInstance()
        {
            return (TUnitOfWork)Activator.CreateInstance(typeof(TUnitOfWork));
        }

        public virtual TIRepository GetInstance<TIRepository>()
            where TIRepository : IRepository
        {
            return (TIRepository)Activator.CreateInstance(Repositories[typeof(TIRepository).Name], DataConnection);
        }
    }
}
