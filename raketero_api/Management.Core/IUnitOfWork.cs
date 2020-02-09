using System;
using System.Collections.Generic;

namespace Management.Core
{
    public interface IUnitOfWork : IDisposable
    {
        void Register(IRepository repository);
        void Register(IList<IRepository> repositories);
        void SaveChanges();
        void CancelChanges();
    }

    public abstract class UnitOfWorkBase : IUnitOfWork
    {
        protected readonly List<TransactionBase> Transactions = new List<TransactionBase>();

        public virtual void Register(IRepository repository)
        {
            Transactions.Add(repository.Transaction);
        }

        public void Register(IList<IRepository> repositories)
        {
            ((List<IRepository>)repositories).ForEach(repo => Register(repo));
        }

        public virtual void SaveChanges()
        {
            Transactions.ForEach(tranx => tranx.Commit());
        }

        public virtual void CancelChanges()
        {
            Transactions.ForEach(tranx => tranx.Rollback());
        }

        public virtual void Dispose()
        {
            Transactions.ForEach(tranx => tranx.Dispose());
        }
    }
}
