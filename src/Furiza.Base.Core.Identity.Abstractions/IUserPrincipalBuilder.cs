using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Furiza.Base.Core.Identity.Abstractions
{
    public interface IUserPrincipalBuilder<out TUserPrincipal, TScopedRoleAssignment>
        where TUserPrincipal : IUserPrincipal
        where TScopedRoleAssignment : IScopedRoleAssignment
    {
        TUserPrincipal UserPrincipal { get; }

        Guid GetCurrentClientId();
        Task<IEnumerable<TScopedRoleAssignment>> GetScopedRoleAssignmentsAsync();
    }

    public interface IUserPrincipalBuilder : IUserPrincipalBuilder<IUserPrincipal, IScopedRoleAssignment>
    {
    }
}