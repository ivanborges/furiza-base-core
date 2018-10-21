using System;
using System.Threading.Tasks;

namespace Furiza.Base.Core.SeedWork
{
    public interface IAggregateReadOnlyRepository<A> where A : IAggregateRoot
    {
        A GetById(Guid id);
        Task<A> GetByIdAsync(Guid id);
    }
}