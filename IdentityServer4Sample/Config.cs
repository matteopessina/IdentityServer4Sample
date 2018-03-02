using System;
using System.Collections.Generic;
using IdentityServer4;
using IdentityServer4.Models;

namespace IdentityServer4Sample
{
    internal class Config
    {
        internal static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("api1", "My API")
            };
        }

        internal static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                //new Client
                //{
                //    ClientId = "client",

                //    // no interactive user, use the clientid/secret for authentication
                //    //AllowedGrantTypes = GrantTypes.ClientCredentials,

                //    AllowedGrantTypes = GrantTypes.Implicit,
                    

                //    // secret for authentication
                //    //ClientSecrets =
                //    //{
                //    //    new Secret("secret".Sha256())
                //    //},

                //    // scopes that client has access to
                //    AllowedScopes = { "api1" }
                //},
                // JavaScript Client
                new Client
                {
                    ClientId = "js",
                    ClientName = "JavaScript Client",
                    AllowedGrantTypes = GrantTypes.Implicit,
                    AllowAccessTokensViaBrowser = true,

                    RedirectUris =           { "https://localhost:44393/callback.html" },
                    PostLogoutRedirectUris = { "https://localhost:44393/index.html" },
                    AllowedCorsOrigins =     { "https://localhost:44393" },

                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "api1"
                    }
                }
            };
        }
    }
}