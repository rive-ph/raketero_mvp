namespace Management.Core
{
    public interface IEntity { }

    public interface IEntity<TIDType> : IEntity
    {
        TIDType Id { get; set; }
    }
}
