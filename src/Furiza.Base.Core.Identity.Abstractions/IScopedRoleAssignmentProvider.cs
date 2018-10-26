using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Furiza.Base.Core.Identity.Abstractions
{
    public interface IScopedRoleAssignmentProvider
    {
        Task<IEnumerable<IScopedRoleAssignment>> GetUserScopedRoleAssignmentsAsync(string username, Guid clientId);
    }
}