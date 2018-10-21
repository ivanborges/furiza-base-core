using System;

namespace Furiza.Base.Core.Identity.Abstractions
{
    public interface IRoleData
    {
        string Name { get; set; }
        DateTime? CreationDate { get; set; }
        string CreationUser { get; set; }
    }

    public enum Role
    {
        Superuser,
        Administrator,
        User
    }
}