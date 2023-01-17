// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4;

using IdentityServer4.Models;
using System.Collections.Generic;

namespace UpSchool_Microservices.identityserver
{
    public static class Config
    {
        public static IEnumerable<ApiResource> ApiResources =>
                   new ApiResource[]
                   {
                        new ApiResource("Resource_Catalogue"){Scopes={"Catalogue_FullPermission"} },
                        new ApiResource("Resource_Order"){Scopes={ "Order_FullPermission" } },
                        new ApiResource("Resource_Discount"){Scopes={"Discount_FullPermission"} },
                        new ApiResource("Resource_Basket"){Scopes={ "Basket_FullPermission" } },
                        new ApiResource("Resource_Payment"){Scopes={ "Payment_FullPermission" } },
                        new ApiResource("Resource_Photo_Stock"){Scopes={ "Photo_Stock_FullPermission" } },
                   };

        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {
                new ApiScope("Catalogue_FullPermission", "Full permission for the Catalogue api"),
                new ApiScope("Order_FullPermission", "Full permission for the Order api"),
                new ApiScope("Discount_FullPermission", "Full permission for the Discount api"),
                new ApiScope("Basket_FullPermission", "Full permission for the Basket api"),
                new ApiScope("Payment_FullPermission", "Full permission for the Payment api"),
                new ApiScope("Photo_Stock_FullPermission", "Full permission for the Photo Stock api"),
                new ApiScope(IdentityServerConstants.LocalApi.ScopeName)
            };

        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                // m2m client credentials flow client
                new Client
                {
                    ClientId = "m2m.client",
                    ClientName = "Client Credentials Client",

                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets = { new Secret("secret".Sha256()) },

                    AllowedScopes = { "Catalogue_FullPermission", "Order_FullPermission","Discount_FullPermission", "Basket_FullPermission", "Payment_FullPermission", "Photo_Stock_FullPermission" 
                    ,IdentityServerConstants.LocalApi.ScopeName}
                   
                },

                // interactive client using code flow + pkce
                new Client
                {
                    ClientId = "interactive",
                    ClientSecrets = { new Secret("49C1A7E1-0C79-4A89-A3D6-A37998FB86B0".Sha256()) },

                    AllowedGrantTypes = GrantTypes.Code,

                    RedirectUris = { "https://localhost:44300/signin-oidc" },
                    FrontChannelLogoutUri = "https://localhost:44300/signout-oidc",
                    PostLogoutRedirectUris = { "https://localhost:44300/signout-callback-oidc" },

                    AllowOfflineAccess = true,
                    AllowedScopes = { "openid", "profile", "scope2" }
                },
            };
    }
}