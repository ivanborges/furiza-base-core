using System;
using System.Threading.Tasks;

namespace Furiza.Base.Core.SeedWork
{
    public interface IEntityReadOnlyRepository<E> where E : Entity
    {
        E GetById(Guid id);
        Task<E> GetByIdAsync(Guid id);
    }
}