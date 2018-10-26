using System;
using System.Collections.Generic;

namespace Furiza.Base.Core.Identity.Abstractions
{
    public interface IUserData
    {
        string UserName { get; }
        string FullName { get; }
        string Email { get; }
        string HiringType { get; }
        string Company { get; }
        string Department { get; }
        DateTime? CreationDate { get; }
        string CreationUser { get; }
        ICollection<IClaimData> Claims { get; }
        ICollection<IRoleAssignment> RoleAssignments { get; }
    }
}