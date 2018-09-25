using System.Threading.Tasks;

namespace Furiza.Base.Core.SeedWork
{
    public interface IUnitOfWork
    {
        int SaveEntities();
        Task<int> SaveEntitiesAsync();
    }
}