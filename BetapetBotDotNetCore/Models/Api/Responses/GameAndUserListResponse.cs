using System;
using System.Collections.Generic;
using BetapetBotDotNetCore.Models.Api.Responses.Subclasses;
using BetapetBotDotNetCore.Models.Serialization;
using Newtonsoft.Json;

namespace BetapetBotDotNetCore.Models.Api.Responses
{
    public class GameAndUserListResponse
    {
        [JsonProperty("time")]
        public long Time { get; set; }

        [JsonProperty("games")]
        public List<Game> Games { get; set; }

        [JsonProperty("users")]
        public List<User> Users { get; set; }

        [JsonProperty("shop")]
        public long Shop { get; set; }

        [JsonProperty("google_play_price")]
        public long GooglePlayPrice { get; set; }

        public static GameAndUserListResponse FromJson(string json) => JsonConvert.DeserializeObject<GameAndUserListResponse>(json, Converter.Settings);
    }
}
