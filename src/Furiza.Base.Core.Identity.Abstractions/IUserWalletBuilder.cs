using System.Collections.Generic;
using System.Threading.Tasks;

namespace Furiza.Base.Core.Identity.Abstractions
{
    public interface IUserWalletBuilder<out TUserWallet, TScopedRoleAssignment>
        where TUserWallet : IUserWallet
        where TScopedRoleAssignment : IScopedRoleAssignment
    {
        TUserWallet UserWallet { get; }
        Task<IEnumerable<TScopedRoleAssignment>> GetScopedRoleAssignmentsAsync();
    }

    public interface IUserWalletBuilder : IUserWalletBuilder<IUserWallet, IScopedRoleAssignment>
    {
    }
}