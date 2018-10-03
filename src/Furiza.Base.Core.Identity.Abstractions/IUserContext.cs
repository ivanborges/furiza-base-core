namespace Furiza.Base.Core.Identity.Abstractions
{
    public interface IUserContext<TUserData, TRoleData, TClaimData> 
        where TUserData : IUserData
        where TRoleData : IRoleData
        where TClaimData : IClaimData
    {
        TUserData UserData { get; }
    }
}