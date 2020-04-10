using md_api_tests.Utils.Stock.Model;
using RestSharp;
using System;

namespace md_api_tests.Utils.Stock
{
    public class StockClient : RestClientBase
    {
        private IRestRequest request;

        public StockClient(string baseUrl) : base(baseUrl)
        {
        }

        public StockResponseModel CreateStock(string token, StockRequestModel stockRequest)
        {
            request = GivenRequest(token, Method.POST);
            request.AddJsonBody(stockRequest);
            Console.WriteLine("Создание склада");
            var response = Execute<StockResponseModel>(request);
            Console.WriteLine(response.ResponseUri.ToString());
            Console.WriteLine(response.Content);

            return response.Data;
        }

        public StockResponseModel GetStock(string token)
        {
            request = GivenRequest(token, Method.GET);
            Console.WriteLine("Данные склада по ID");
            var response = Execute<StockResponseModel>(request);
            Console.WriteLine(response.ResponseUri.ToString());
            Console.WriteLine(response.Content);

            return response.Data;
        }

        public StockListResponseModel GetStockList(string token)
        {
            request = GivenRequest(token, Method.GET);
            Console.WriteLine("Данные складов");
            var response = Execute<StockListResponseModel>(request);
            Console.WriteLine(response.ResponseUri.ToString());
            Console.WriteLine(response.Content);

            return response.Data;
        }

        public StockResponseModel UpdateStock(string token, StockRequestModel stockRequest)
        {
            request = GivenRequest(token, Method.PUT);
            request.AddJsonBody(stockRequest);
            Console.WriteLine("Редактирование склада");
            var response = Execute<StockResponseModel>(request);
            Console.WriteLine(response.ResponseUri.ToString());
            Console.WriteLine(response.Content);

            return response.Data;
        }

        public string DeleteStock(string token)
        {
            request = GivenRequest(token, Method.DELETE);
            Console.WriteLine("Удаление склада");
            var response = Execute(request);
            Console.WriteLine(response.ResponseUri.ToString());
            Console.WriteLine(response.Content);

            return response.Content;
        }
               
        private IRestRequest GivenRequest(string token, Method method)
        {
            var request = new RestRequest(method);
            request.AddHeader("Authorization", string.Format("Bearer {0} s", token));

            return request;
        }
    }
}
