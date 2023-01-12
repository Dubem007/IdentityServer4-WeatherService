using IdentityServer4.Models;
using IdentityServer4;

namespace IdentityServer.IdentityConfiguration
{
    public class Clients
    {
        public static IEnumerable<Client> Get()
        {
            return new List<Client>
        {
            new Client
            {
                ClientId = "weatherApi",
                ClientName = "ASP.NET Core Weather Api",
                AllowedGrantTypes = GrantTypes.ClientCredentials,
                ClientSecrets = new List<Secret> {new Secret("ProjectGuide".Sha256())},
                AllowedScopes = new List<string> {"weatherApi.read", "weatherApi.write" }
            },
            new Client
            {
                ClientId = "studentApi",
                ClientName = "ASP.NET Core Student Api",
                AllowedGrantTypes = GrantTypes.ClientCredentials,
                ClientSecrets = new List<Secret> {new Secret("ProjectGuide".Sha256())},
                AllowedScopes = new List<string> { "studentApi.read", "studentApi.write" }
            },
            new Client
            {
                ClientId = "oidcMVCApp",
                ClientName = "Sample ASP.NET Core MVC Web App",
                ClientSecrets = new List<Secret> {new Secret("ProjectGuide".Sha256())},

                AllowedGrantTypes = GrantTypes.Code,
                RedirectUris = new List<string> {"https://localhost:7168/signin-oidc"},
                AllowedScopes = new List<string>
                {
                    IdentityServerConstants.StandardScopes.OpenId,
                    IdentityServerConstants.StandardScopes.Profile,
                    IdentityServerConstants.StandardScopes.Email,
                    "role",
                    "weatherApi.read",
                    "weatherApi.write",
                    "studentApi.read",
                    "studentApi.write"
                },

                RequirePkce = true,
                AllowPlainTextPkce = false
            }
        };
        }
    }
}
