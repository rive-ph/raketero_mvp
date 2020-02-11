using System;

namespace Management.Core
{
    public interface IRepository : IDisposable
    {
        TransactionBase Transaction { get; }
    }

    public abstract class RepositoryBase<TDataConnection>
    {
        protected TDataConnection DataConnection;

        public RepositoryBase(TDataConnection connection)
        {
            DataConnection = connection;
        }
    }
}
