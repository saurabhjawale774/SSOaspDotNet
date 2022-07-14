using Microsoft.IdentityModel.Tokens;

namespace SSOwebApp3
{
    internal class OpenIdConnectOptions
    {
        public OpenIdConnectOptions()
        {
        }

        public string AuthenticationScheme { get; set; }
        public string SignInScheme { get; set; }
        public string Authority { get; set; }
        public string ResponseType { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public bool GetClaimsFromUserInfoEndpoint { get; set; }
        public TokenValidationParameters TokenValidationParameters { get; set; }
        public bool SaveTokens { get; set; }
    }
}