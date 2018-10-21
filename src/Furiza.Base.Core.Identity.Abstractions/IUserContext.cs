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

    public interface IUserContext<out TUserData, TRoleData, TClaimData> : IUserContext<TUserData>
        where TUserData : IUserData
        where TRoleData : IRoleData
        where TClaimData : IClaimData
    {
    }
}