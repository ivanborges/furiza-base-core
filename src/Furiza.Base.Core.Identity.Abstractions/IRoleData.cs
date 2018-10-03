namespace Furiza.Base.Core.Identity.Abstractions
{
    public interface IRoleData
    {
        string Name { get; set; }
    }

    public enum Role
    {
        Superuser,
        Administrator,
        User
    }
}