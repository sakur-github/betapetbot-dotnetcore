using System;
using BetapetBotDotNetCore.Models.Api.Responses;
using Newtonsoft.Json;

namespace BetapetBotDotNetCore.Models.Serialization
{
    public static class Serialize
    {
        public static string ToJson(this LoginResponse self) => JsonConvert.SerializeObject(self, Converter.Settings);
        public static string ToJson(this GameAndUserListResponse self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }
}
