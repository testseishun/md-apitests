using System;

namespace md_api_tests.Utils.Tester
{
    public class UserHelper
    {
        public static string GetUserLogin()
        {
            return string.Format("{0}.{1}.{2}", GetTimeForGenerateUserLogin(), Environment.MachineName, "tester@moedelo.org");
        }

        private static string GetTimeForGenerateUserLogin()
        {
            return DateTime.Now.ToString("hh.mm.ss.ffffff");
        }
    }
}
