using System.Collections.Generic;

namespace Furiza.Base.Core.SeedWork
{
    public interface IEntityWriteOnlyRepository<in E> where E : Entity
    {
        IUnitOfWork UnitOfWork { get; }

        void Insert(E entity);
        void BatchInsert(IEnumerable<E> entities);

        void Update(E entity);
        void BatchUpdate(IEnumerable<E> entities);
    }
}
