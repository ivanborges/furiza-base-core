using System;

namespace Furiza.Base.Core.Identity.Abstractions
{
    public interface IUserTokenizer<in TUserData> where TUserData : IUserData
    {
        GenerateTokenResult GenerateToken(TUserData userData);
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