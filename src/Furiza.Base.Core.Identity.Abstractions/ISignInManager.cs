using System.Threading.Tasks;

namespace Furiza.Base.Core.Identity.Abstractions
{
    public interface ISignInManager<TUserData> where TUserData : IUserData
    {
        Task<bool> CheckPasswordSignInAsync(TUserData user, string password);
    }
}