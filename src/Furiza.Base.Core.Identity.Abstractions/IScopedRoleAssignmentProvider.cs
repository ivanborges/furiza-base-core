using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Furiza.Base.Core.Identity.Abstractions
{
    public interface IScopedRoleAssignmentProvider
    {
        Task<IEnumerable<TScopedRoleAssignment>> GetUserScopedRoleAssignmentsAsync<TScopedRoleAssignment>(string username, Guid clientId)
            where TScopedRoleAssignment : IScopedRoleAssignment;
    }
}