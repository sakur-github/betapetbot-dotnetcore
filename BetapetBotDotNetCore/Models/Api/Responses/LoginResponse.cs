using System;
using Newtonsoft.Json;

namespace BetapetBotDotNetCore.Models.Api.Responses
{
    public class LoginResponse
    {
        [JsonProperty("result")]
        public bool Result { get; set; }

        [JsonProperty("userId")]
        public long UserId { get; set; }

        [JsonProperty("authKey")]
        public string AuthKey { get; set; }

        public static LoginResponse FromJson(string json) => JsonConvert.DeserializeObject<LoginResponse>(json, Converter.Settings);
    }
}
