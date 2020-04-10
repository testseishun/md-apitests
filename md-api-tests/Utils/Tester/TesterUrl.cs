namespace md_api_tests.Utils.Tester
{
    public class TesterUrl
    {
        public readonly static string CREATE_USER = "{0}/CreateUser?Login={1}&FirmRegType={2}&PaymentStatus={3}" +
            "&WithErReports={4}&IsOOO={5}&IsENVD={6}&IsUsn={7}&UsnSize={8}&IsOsno={9}&IsEmployer={10}&PriceList={11}&ClientId={12}";
        
        public readonly static string CREATE_EMPLOYEE = "{0}/CreateWorker?Login={1}&Name={2}&Surname={3}&Sex={4}&DateOfStartWork={5}" +
            "&Salary={6}&Vacancy={7}&isNotStaff={8}&Inn={9}&Snils={10}";
        
        public const string FILL_REQUISITES = "{0}/FillRequisites?Login={1}";

        public const string CHANGE_STATICTICS_FLAG = "{0}/ChangeStatisticFlag?Login={1}&IsConsidered={2}";

        public const string SWITCH_ON_STOCK = "{0}/SetStockMode?Login={1}";
    }
}
