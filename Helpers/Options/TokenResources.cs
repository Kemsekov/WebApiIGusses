using Microsoft.Extensions.Configuration;

namespace WebApi.Helpers
{
    public class Token
    {
        public string token_type{get;set;}
        public string scope{get;set;}
        public string refresh_token{get;set;}
        public Token()
        {}
    }
}