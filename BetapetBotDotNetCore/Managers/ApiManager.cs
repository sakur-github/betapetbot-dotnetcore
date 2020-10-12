using System;
using System.Net.Http;
using System.Threading.Tasks;
using BetapetBotDotNetCore.Models.Api;
using BetapetBotDotNetCore.Models.Api.Responses;

namespace BetapetBotDotNetCore.Managers
{
    public class ApiManager
    {
        private const string baseUrl = "https://mobile-app-se.betapet.se/";

        private HttpClient client;
        private LoginResponse userCredentials;

        public ApiManager()
        {
            client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("User-Agent", "Betapet/1.47 CFNetwork/1128.0.1 Darwin/19.6.0");
        }

        private async Task<string> GetResponse(string method)
        {
            return await client.GetStringAsync(method);
        }

        public async Task<LoginResponse> Login(string username, string password)
        {
            RequestParameterCollection parameters = new RequestParameterCollection();
            parameters.AddParameter("username", username);
            parameters.AddParameter("password", password);

            string apiResponse = await GetResponse(baseUrl + "login.php" + parameters.ToString());

            userCredentials = LoginResponse.FromJson(apiResponse);

            return LoginResponse.FromJson(apiResponse);
        }

        public async Task<GameAndUserListResponse> GetGameAndUserList(LoginResponse loginResponse = null)
        {
            if (loginResponse == null)
            {
                if (userCredentials == null || !userCredentials.Result)
                    throw new Exception("User not logged in! Use Login first");
            }
            else
            {
                userCredentials = loginResponse;
            }

            RequestParameterCollection parameters = new RequestParameterCollection();
            parameters.AddParameter("type", "gameanduserlist");
            parameters.AddParameter("device_id", "173FA2A77FA8260CD1EA6C36D66478D3A14E23786A480485B3F09962ABF46540");
            parameters.AddParameter("userid", userCredentials.UserId);
            parameters.AddParameter("authkey", userCredentials.AuthKey);

            string apiResponse = await GetResponse(baseUrl + "matchmake.php" + parameters.ToString());

            return GameAndUserListResponse.FromJson(apiResponse);
        }
    }
}
