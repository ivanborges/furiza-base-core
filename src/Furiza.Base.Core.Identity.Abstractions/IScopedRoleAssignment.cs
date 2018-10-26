using System;

namespace Furiza.Base.Core.Identity.Abstractions
{
    public interface IScopedRoleAssignment
    {
        Guid ClientId { get; set; }
        string UserName { get; set; }
        string Role { get; set; }
        string Scope { get; set; }
    }
}