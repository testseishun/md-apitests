using md_api_tests.Utils.Oauth.Model;
using RestSharp;
using System;

namespace md_api_tests.Utils.Oauth 
{
    public class OauthClient : RestClientBase
    {
        private readonly string md5DefaultPassword = "acb2adb7c4c804b703d50788a43814ac";

        public OauthClient(string baseUrl) : base(baseUrl)
        {
        }

        public string GetAutorizationToken(string login)
        {
            var oauth = new OauthModel
            {
                Password = md5DefaultPassword,
                Login = login
            };

            var request = new RestRequest(Method.POST);
            request.AddHeader("Accept", "application/json");
            request.AddJsonBody(oauth);
            Console.WriteLine("Получение token");
            response = Execute(request);
            Console.WriteLine(response.ResponseUri.ToString());
            return GetMdAuthToken(response);
        }

        private string GetMdAuthToken(IRestResponse response)
        {
            string cookie = null;
            foreach (var c in response.Cookies)
            {
                Console.WriteLine(c.Name);
                Console.WriteLine(c.Value);
                if (c.Name.Contains("md-auth") == true)
                {
                    cookie = c.Value.ToString();
                }
            }
            return cookie;
        }
    }
}
