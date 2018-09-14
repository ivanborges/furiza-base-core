using System.Threading.Tasks;

namespace FF.Base.Core.SeedWork
{
    public interface IUnitOfWork
    {
        int SaveEntities();
        Task<int> SaveEntitiesAsync();
    }
}