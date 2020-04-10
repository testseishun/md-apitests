using RestSharp;
using System;
using System.Net;

namespace md_api_tests.Utils.Tester
{
    public class TesterClient : RestClientBase
    {
        public TesterClient(string baseUrl) : base(baseUrl)
        {
        }

        public void CreateUser()
        {
            var request = new RestRequest(Method.GET);
            var response = Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Console.WriteLine("Пользователь создан");
            }
            else
            {
                Console.WriteLine("Ошибка при создании пользователя");
            }
        }

        public void FillRequisites()
        {
            var request = new RestRequest(Method.GET);
            var response = Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Console.WriteLine("Реквизиты заполнены успешно");
            }
            else
            {
                Console.WriteLine("Ошибка при заполнении реквизитов");
            }
        }

        public void ChangeStatisticsFlag()
        {
            var request = new RestRequest(Method.GET);
            var response = Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Console.WriteLine("Успешная смена учета логина в статистике");
            }
            else
            {
                Console.WriteLine("Ошибка при смене учета логина в статистике");
            }
        }

        public void SwitchOnStock()
        {
            var request = new RestRequest(Method.GET);
            var response = Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Console.WriteLine("Склад успешно включен");
            }
            else
            {
                Console.WriteLine("Ошибка при включении склада");
            }
        }
    }
}
