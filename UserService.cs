using System;
using System.Security.Authentication;
using RPMWare.Api.Client.Properties;
using RPMWare.Api.Client.RPMWareUser;

namespace RPMWare.Api.Client
{
    public static class UserService
    {
        public static string GetApiKey()
        {
            string email = Settings.Default.ApiEmail;
            // Do as I say, not as I do. You should store your password encrypted.
            string password = Settings.Default.ApiPassword;

            var service = new User();
            Console.WriteLine("Logging in as {0}.", email);
            Console.WriteLine("Calling User Service at: {0}", service.Url);

            Result result = service.Login(email, password);
            if (result.Success == "SUCCESS")
            {
                var data = result.Data as ApiToken;
                if (data != null)
                {
                    return data.Token;
                }
                throw new AuthenticationException("Result.Data was null.");
            }

            throw new AuthenticationException(result.Message);
        }
    }
}
