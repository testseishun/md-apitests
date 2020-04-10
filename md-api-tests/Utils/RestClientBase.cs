using RestSharp;
using System;

namespace md_api_tests.Utils
{
    public class RestClientBase : RestClient
    {
        protected IRestResponse response;

        public RestClientBase(string baseUrl)
        {
            BaseUrl = new Uri(baseUrl);
        }

        public override IRestResponse Execute(IRestRequest request)
        {
            try
            {
                response = base.Execute(request);
            }
            catch (Exception e)
            {
                throw e;

            }
            return response;
        }

        public override IRestResponse<T> Execute<T>(IRestRequest request)
        {
            IRestResponse<T> response;
            try
            {
                response = base.Execute<T>(request);
            }
            catch (Exception e)
            {
                throw e;

            }
            return response;
        }
    }
}
