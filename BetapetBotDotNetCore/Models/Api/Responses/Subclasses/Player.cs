using System;
using BetapetBotDotNetCore.Models.Serialization;
using Newtonsoft.Json;

namespace BetapetBotDotNetCore.Models.Api.Responses.Subclasses
{
    public class Player
    {
        [JsonProperty("userid")]
        [JsonConverter(typeof(LongParseStringConverter))]
        public long Userid { get; set; }

        [JsonProperty("hand", NullValueHandling = NullValueHandling.Ignore)]
        public string Hand { get; set; }

        [JsonProperty("score")]
        [JsonConverter(typeof(LongParseStringConverter))]
        public long Score { get; set; }

        [JsonProperty("chat", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(LongParseStringConverter))]
        public long? Chat { get; set; }

        [JsonProperty("bingos")]
        [JsonConverter(typeof(LongParseStringConverter))]
        public long Bingos { get; set; }

        [JsonProperty("hand_cnt")]
        [JsonConverter(typeof(LongParseStringConverter))]
        public long HandCount { get; set; }
    }
}