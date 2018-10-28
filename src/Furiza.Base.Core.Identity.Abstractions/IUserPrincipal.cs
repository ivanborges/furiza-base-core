using System.Collections.Generic;
using System.Security.Claims;

namespace Furiza.Base.Core.Identity.Abstractions
{
    public interface IUserPrincipal
    {
        string UserName { get; set; }
        string FullName { get; set; }
        string Email { get; set; }
        string HiringType { get; set; }
        string Company { get; set; }
        string Department { get; set; }
        ICollection<Claim> Claims { get; set; }
        ICollection<IRoleAssignment> RoleAssignments { get; set; }
    }
}