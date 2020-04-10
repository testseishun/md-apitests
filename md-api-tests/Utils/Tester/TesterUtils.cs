namespace md_api_tests.Utils.Tester
{
    public class TesterUtils
    {
        public static string CreateAccountingUserIpUsn15()
        {
            string login = UserHelper.GetUserLogin();
            string uri = UriBuilder.GetCreateAccountingUserIpUsn15EnvdUrl(login);
            new TesterClient(uri).CreateUser();

            return login;
        }

        public static string CreateAccountingUserIpUsn15AndFillRequisites()
        {
            string login = UserHelper.GetUserLogin();
            string uri = UriBuilder.GetCreateAccountingUserIpUsn15EnvdUrl(login);
            new TesterClient(uri).CreateUser();
            FillRequisites(login);
            ExcludeFromStatistics(login);

            return login;
        }

        public static string CreateBizUserOooUsn15AndFillRequisites()
        {
            string login = UserHelper.GetUserLogin();
            string uri = UriBuilder.GetCreateBizUserOooUsn15EnvdUrl(login);
            new TesterClient(uri).CreateUser();
            FillRequisites(login);
            ExcludeFromStatistics(login);

            return login;
        }

        public static void SwitchOnStock(string login)
        {
            string uri = UriBuilder.GetSwitchOnStockByLoginUrl(login);
            new TesterClient(uri).SwitchOnStock();
        }

        private static void FillRequisites(string login)
        {
            string uri = UriBuilder.GetFillRequisitesByLoginUrl(login);
            new TesterClient(uri).FillRequisites();
        }

        private static void ExcludeFromStatistics(string login)
        {
            string uri = UriBuilder.GetChangeStatisticsFlagByLoginUrl(login, false);
            new TesterClient(uri).ChangeStatisticsFlag();
        }

        private static void IncludeInStatistics(string login)
        {
            string uri = UriBuilder.GetChangeStatisticsFlagByLoginUrl(login, true);
            new TesterClient(uri).ChangeStatisticsFlag();
        }
    }
}
