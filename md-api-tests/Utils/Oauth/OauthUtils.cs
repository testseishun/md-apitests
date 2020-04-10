using System.Configuration;

namespace md_api_tests.Utils.Oauth
{
    public class OauthUtils
    {
        private static readonly string oauthUrl = ConfigurationManager.AppSettings["oauthUrl"];

        public static string GetAutorizationToken(string login)
        {
            OauthClient client = new OauthClient(oauthUrl);
            return client.GetAutorizationToken(login);
        }
    }
}
