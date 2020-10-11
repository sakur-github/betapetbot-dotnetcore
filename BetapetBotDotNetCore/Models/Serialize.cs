using System;
using BetapetBotDotNetCore.Models.Api.Responses;
using Newtonsoft.Json;

namespace BetapetBotDotNetCore.Models
{
    public static class Serialize
    {
        public static string ToJson(this LoginResponse self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }
}
