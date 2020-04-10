namespace md_api_tests.Utils.Oauth.Model
{
    public class OauthModel
    {
        public string Password;
        public string Login;

        public string GetLogin
        {
            get => Login;
            set => Login = value;
        }

        public string GetPassword
        {
            get => Password;
            set => Password = value;
        }

        public OauthModel()
        {
        }

        public OauthModel(string pass, string login)
        {
            GetLogin = login;
            GetPassword = pass;
        }
    }
}
