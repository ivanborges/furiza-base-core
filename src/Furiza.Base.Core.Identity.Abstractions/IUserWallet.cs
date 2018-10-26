using System.Collections.Generic;
using System.Security.Claims;

namespace Furiza.Base.Core.Identity.Abstractions
{
    public interface IUserWallet
    {
        string UserName { get; }
        string FullName { get; }
        string Email { get; }
        string HiringType { get; }
        string Company { get; }
        string Department { get; }
        ICollection<Claim> Claims { get; }
        ICollection<IRoleAssignment> RoleAssignments { get; }
    }
}