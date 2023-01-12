using IdentityServer4.Models;

namespace IdentityServer.IdentityConfiguration
{
    public class Scopes
    {
        public static IEnumerable<ApiScope> GetApiScopes()
        {
            return new[]
            {
            new ApiScope("weatherApi.read", "Read Access to Weather API"),
            new ApiScope("weatherApi.write", "Write Access to Weather API"),
            new ApiScope("studentApi.read", "Read Access to Student API"),
            new ApiScope("studentApi.write", "Write Access to Student API"),
            };
        }
    }
}
