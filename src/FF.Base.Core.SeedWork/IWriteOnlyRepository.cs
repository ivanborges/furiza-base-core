using System.Collections.Generic;

namespace FF.Base.Core.SeedWork
{
    public interface IWriteOnlyRepository<T> where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }

        void Insert(T entity);
        void BatchInsert(IEnumerable<T> entities);

        void Update(T entity);
        void BatchUpdate(IEnumerable<T> entities);
    }
}