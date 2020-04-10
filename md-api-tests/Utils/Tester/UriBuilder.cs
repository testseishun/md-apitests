using md_api_tests.Utils.Tester.Model;
using System;
using System.Configuration;

namespace md_api_tests.Utils.Tester
{
    public class UriBuilder
    {
        private readonly static string testerHost = ConfigurationManager.AppSettings["testerHost"];

        public static string GetCreateAccountingUserIpUsn15EnvdUrl(string login)
        {
            UserModel user = new UserModel
            {
                Login = login,
                RegistrationType = RegistrationType.UsnAccountant,
                PriceListType = PriceListType.ProfessionalUsn,
                TaxSystem = TaxSystem.USN_15_ENVD
            };          

            string uri = GetCreateUserUrl(user);
            Console.WriteLine("Логин пользователя " + login);
            Console.WriteLine(uri);

            return uri;
        }

        public static string GetCreateBizUserOooUsn15EnvdUrl(string login)
        {
            UserModel user = new UserModel
            {
                Login = login,
                FirmType = FirmType.OOO,
                RegistrationType = RegistrationType.Business,
                PriceListType = PriceListType.UsnMax12Month,
                TaxSystem = TaxSystem.USN_15_ENVD
            };

            string uri = GetCreateUserUrl(user);
            Console.WriteLine("Логин пользователя " + login);
            Console.WriteLine(uri);

            return uri;
        }

        public static string GetFillRequisitesByLoginUrl(string login)
        {
            string uri = GetFillRequisitesUrl(login);
            Console.WriteLine("Заполнение реквизитов для пользователя " + login);
            Console.WriteLine(uri);

            return uri;
        }

        public static string GetSwitchOnStockByLoginUrl(string login)
        {
            string uri = GetSwitchOnStockUrl(login);
            Console.WriteLine("Включение склада для пользователя " + login);
            Console.WriteLine(uri);

            return uri;
        }

        public static string GetChangeStatisticsFlagByLoginUrl(string login, bool includeInStatistics)
        {
            string uri = GetChangeStatisticsFlagUrl(login, includeInStatistics);
            Console.WriteLine("Смена учёта логина в статистике " + login);
            Console.WriteLine(uri);

            return uri;
        }

        private static string GetCreateUserUrl(UserModel user)
        {
            return string.Format(TesterUrl.CREATE_USER, new string[]
            {
                testerHost,
                user.Login,
                user.RegistrationType.ToString(),
                user.PaymentStatus.ToString(),
                user.GetReportingStatus().ToString(),
                user.GetFirmType().ToString(),
                user.GetEnvd().ToString(),
                user.GetUsn().ToString(),
                user.GetUsnSize(),
                user.GetOsnoMode().ToString(),
                user.GetEmployeeMode().ToString(),
                user.PriceListType.ToString(),
                user.ClientId
            });
        }

        private static string GetFillRequisitesUrl(string login)
        {
            return string.Format(TesterUrl.FILL_REQUISITES, new string[] { testerHost, login });
        }

        private static string GetChangeStatisticsFlagUrl(string login, bool includeInStatistics)
        {
            return string.Format(TesterUrl.CHANGE_STATICTICS_FLAG, new string[] { testerHost, login, includeInStatistics.ToString() });
        }

        private static string GetSwitchOnStockUrl(string login)
        {
            return string.Format(TesterUrl.SWITCH_ON_STOCK, new string[] { testerHost, login });
        }
    }
}
