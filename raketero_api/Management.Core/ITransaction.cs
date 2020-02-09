namespace Management.Core
{
    public interface ITransaction { }

    public abstract class TransactionBase : ITransaction
    {
        protected internal abstract void Commit();
        protected internal abstract void Rollback();
        protected internal abstract void Dispose();
    }
}
