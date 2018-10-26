namespace Furiza.Base.Core.Identity.Abstractions
{
    public interface IUserContext
    {
        IUserData UserData { get; }
    }

    public interface IUserContext<out TUserData> 
        where TUserData : IUserData
    {
        TUserData UserData { get; }
    }

    public interface IUserContext<out TUserData, TClaimData, TRoleAssignment> : IUserContext<TUserData>
        where TUserData : IUserData
        where TClaimData : IClaimData
        where TRoleAssignment : IRoleAssignment
    {
    }
}