using md_api_tests.Utils.Oauth;
using md_api_tests.Utils.Stock;
using md_api_tests.Utils.Stock.Model;
using md_api_tests.Utils.Tester;
using NUnit.Framework;

namespace md_api_tests.Tests
{
    [TestFixture]
    public class StockTest
    {
        [Test]
        [Category("StockApiTests")]
        public void BizUserCreateAndGetStock()
        {
            var createStockRequest = new StockRequestModel
            {
                Id = 0,
                Name = "Розничный склад",
                IsMain = false,
                StockType = 2
            };

            string login = TesterUtils.CreateBizUserOooUsn15AndFillRequisites();
            TesterUtils.SwitchOnStock(login);
            string token = OauthUtils.GetAutorizationToken(login);
            StockResponseModel responseCreate = StockUtils.СreateStock(token, createStockRequest);
            StockResponseModel responceGet = StockUtils.GetStock(token, responseCreate.Id);

            Assert.AreEqual(responseCreate.Id, responceGet.Id);
            Assert.AreEqual(createStockRequest.Name, responceGet.Name);
            Assert.AreEqual(createStockRequest.IsMain, responceGet.IsMain);
            Assert.AreEqual(createStockRequest.StockType, responceGet.StockType);
            Assert.AreEqual(responseCreate.SubcontoId, responceGet.SubcontoId);
        }        

        [Test]
        [Category("StockApiTests")]
        public void BizUserCreateUpdateAndGetStock()
        {
            var createStockRequest = new StockRequestModel
            {
                Id = 0,
                Name = "Розничный склад",
                IsMain = false,
                StockType = 2
            };

            string login = TesterUtils.CreateBizUserOooUsn15AndFillRequisites();
            TesterUtils.SwitchOnStock(login);
            string token = OauthUtils.GetAutorizationToken(login);
            StockResponseModel responseCreate = StockUtils.СreateStock(token, createStockRequest);

            var updateStockRequest = new StockRequestModel
            {
                Id = responseCreate.Id,
                Name = "Отредактированный склад",
                IsMain = true,
                StockType = 1
            };

            StockResponseModel responceUpdate = StockUtils.UpdateStock(token, responseCreate.Id, updateStockRequest);
            StockResponseModel responceGet = StockUtils.GetStock(token, responseCreate.Id);

            Assert.AreEqual(updateStockRequest.Id, responceGet.Id);
            Assert.AreEqual(updateStockRequest.Name, responceGet.Name);
            Assert.AreEqual(updateStockRequest.IsMain, responceGet.IsMain);
            Assert.AreEqual(updateStockRequest.StockType, responceGet.StockType);
            Assert.AreEqual(responceUpdate.SubcontoId, responceGet.SubcontoId);
        }
               
        [Test]
        [Category("StockApiTests")]
        public void BizUserCreateAndDeleteStock()
        {
            var createStockRequest1 = new StockRequestModel
            {
                Id = 0,
                Name = "Розничный склад 1",
                IsMain = false,
                StockType = 2
            };

            var createStockRequest2 = new StockRequestModel
            {
                Id = 0,
                Name = "Розничный склад 2",
                IsMain = false,
                StockType = 2
            };

            string login = TesterUtils.CreateBizUserOooUsn15AndFillRequisites();
            TesterUtils.SwitchOnStock(login);
            string token = OauthUtils.GetAutorizationToken(login);
            StockResponseModel responseCreate1 = StockUtils.СreateStock(token, createStockRequest1);
            StockResponseModel responseCreate2 = StockUtils.СreateStock(token, createStockRequest2);
            StockUtils.DeleteStock(token, responseCreate1.Id);
            StockListResponseModel stockList = StockUtils.GetStockList(token, 1, 10);
            int count = stockList.ResourceList.Count;

            Assert.AreEqual(2, count);
        }
    }
}
