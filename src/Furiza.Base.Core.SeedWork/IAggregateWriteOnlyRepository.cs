using System.Collections.Generic;

namespace Furiza.Base.Core.SeedWork
{
    public interface IAggregateWriteOnlyRepository<in A> where A : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }

        void Insert(A aggregate);
        void BatchInsert(IEnumerable<A> aggregates);

        void Update(A aggregate);
        void BatchUpdate(IEnumerable<A> aggregates);
    }
}