using System;

namespace Furiza.Base.Core.Identity.Abstractions
{
    public interface IScopedRoleAssignment
    {
        Guid ClientId { get; }
        string UserName { get; }
        string Role { get; }
        string Scope { get; }
    }
}