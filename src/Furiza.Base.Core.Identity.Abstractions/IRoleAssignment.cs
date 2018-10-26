using System;

namespace Furiza.Base.Core.Identity.Abstractions
{
    public interface IRoleAssignment
    {
        Guid ClientId { get; set; }
        string UserName { get; set; }
        string Role { get; set; }
    }
}