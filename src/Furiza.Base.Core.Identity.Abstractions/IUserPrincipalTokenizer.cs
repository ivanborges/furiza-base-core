using System;

namespace Furiza.Base.Core.Identity.Abstractions
{
    public interface IUserPrincipalTokenizer
    {
        GenerateTokenResult GenerateToken<TUserPrincipal>(TUserPrincipal userPrincipal)
            where TUserPrincipal : IUserPrincipal;
    }

    public class GenerateTokenResult
    {
        public string AccessToken { get; }
        public string RefreshToken { get; }
        public DateTime? Expiration { get; }

        public GenerateTokenResult(string accessToken, string refreshToken, DateTime? expiration)
        {
            AccessToken = accessToken;
            RefreshToken = refreshToken;
            Expiration = expiration;
        }
    }
}