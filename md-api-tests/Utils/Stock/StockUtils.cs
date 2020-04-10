using md_api_tests.Utils.Stock.Model;
using System.Configuration;

namespace md_api_tests.Utils.Stock
{
    public class StockUtils
    {
        private static readonly string restApiUrl = ConfigurationManager.AppSettings["restApiUrl"];
        private static readonly string createStockUrl = "/stock/api/v1/stock";

        public static StockResponseModel СreateStock(string token, StockRequestModel stockRequest)
        {
            string url = restApiUrl + createStockUrl;
            return new StockClient(url).CreateStock(token, stockRequest);
        }

        public static StockResponseModel UpdateStock(string token, int stockId, StockRequestModel stockRequest)
        {
            string url = restApiUrl + createStockUrl + "/" + stockId;
            return new StockClient(url).UpdateStock(token, stockRequest);
        }

        public static string DeleteStock(string token, int stockId)
        {
            string url = restApiUrl + createStockUrl + "/" + stockId;
            return new StockClient(url).DeleteStock(token);
        }

        public static StockResponseModel GetStock(string token, int stockId)
        {
            string url = restApiUrl + createStockUrl + "/" + stockId;
            return new StockClient(url).GetStock(token);
        }

        public static StockListResponseModel GetStockList(string token, int pageNumber, int pageSize)
        {
            string url = string.Format("{0}{1}?pageNo={2}&pageSize={3}", restApiUrl, createStockUrl, pageNumber, pageSize);
            return new StockClient(url).GetStockList(token);
        }
    }
}
