using System.Collections.Generic;
using System.Threading.Tasks;

namespace Furiza.Base.Core.Identity.Abstractions
{
    public interface IUserContext<out TUserWallet, TScopedRoleAssignment>
        where TUserWallet : IUserWallet
        where TScopedRoleAssignment : IScopedRoleAssignment
    {
        TUserWallet UserWallet { get; }
        Task<IEnumerable<TScopedRoleAssignment>> GetScopedRoleAssignmentsAsync();
    }

    public interface IUserContext<out TUserWallet, TScopedRoleAssignment, TRoleAssignment> : IUserContext<TUserWallet, TScopedRoleAssignment>
        where TUserWallet : IUserWallet
        where TScopedRoleAssignment : IScopedRoleAssignment
        where TRoleAssignment : IRoleAssignment
    {
    }

    public interface IUserContext : IUserContext<IUserWallet, IScopedRoleAssignment>
    {
    }
}