using System;
using System.Threading.Tasks;

namespace FF.Base.Core.SeedWork
{
    public interface IReadOnlyRepository<T> where T : IAggregateRoot
    {
        T GetById(Guid id);
        Task<T> GetByIdAsync(Guid id);
    }
}