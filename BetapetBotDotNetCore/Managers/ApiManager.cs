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
            parameters.AddParameter(new RequestParameter("username", username));
            parameters.AddParameter(new RequestParameter("password", password));

            string apiResponse = await GetResponse(baseUrl + "login.php" + parameters.ToString());

            return LoginResponse.FromJson(apiResponse);
        }
    }
}
