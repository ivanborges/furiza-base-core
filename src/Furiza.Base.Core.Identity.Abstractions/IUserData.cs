using System;
using System.Collections.Generic;

namespace Furiza.Base.Core.Identity.Abstractions
{
    public interface IUserData
    {
        Guid Id { get; set; }
        string UserName { get; set; }
        string FullName { get; set; }
        string Email { get; set; }
        string Bond { get; set; }
        string Company { get; set; }
        string Department { get; set; }
        ICollection<IRoleData> Roles { get; set; }
        ICollection<IClaimData> Claims { get; set; }
        DateTime? CreationDate { get; set; }
        string CreationUser { get; set; }
    }
}