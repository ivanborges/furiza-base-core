using System;

namespace Furiza.Base.Core.Identity.Abstractions
{
    public interface IRoleAssignment
    {
        Guid ClientId { get; }
        string UserName { get; }
        string Role { get; }
    }
}