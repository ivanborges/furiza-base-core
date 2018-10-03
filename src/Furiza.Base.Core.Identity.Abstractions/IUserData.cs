using System.Collections.Generic;

namespace Furiza.Base.Core.Identity.Abstractions
{
    public interface IUserData
    {
        string UserName { get; set; }
        string FullName { get; set; }
        string Email { get; set; }
        string Company { get; set; }
        string Department { get; set; }
        ICollection<IRoleData> Roles { get; set; }
        ICollection<IClaimData> Claims { get; set; }
    }
}