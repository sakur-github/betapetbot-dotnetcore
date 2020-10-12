using System;
using System.Collections.Generic;
using BetapetBotDotNetCore.Models.Serialization;
using Newtonsoft.Json;

namespace BetapetBotDotNetCore.Models.Api.Responses.Subclasses
{
    public class Game
    {
        [JsonProperty("gameid")]
        [JsonConverter(typeof(LongParseStringConverter))]
        public long Gameid { get; set; }

        [JsonProperty("start_time")]
        public DateTimeOffset StartTime { get; set; }

        [JsonProperty("board_type")]
        [JsonConverter(typeof(LongParseStringConverter))]
        public long BoardType { get; set; }

        [JsonProperty("player_cnt")]
        [JsonConverter(typeof(LongParseStringConverter))]
        public long PlayerCnt { get; set; }

        [JsonProperty("wordlist")]
        [JsonConverter(typeof(LongParseStringConverter))]
        public long Wordlist { get; set; }

        [JsonProperty("activity")]
        [JsonConverter(typeof(LongParseStringConverter))]
        public long Activity { get; set; }

        [JsonProperty("activity_time")]
        public DateTimeOffset ActivityTime { get; set; }

        [JsonProperty("active")]
        [JsonConverter(typeof(LongParseStringConverter))]
        public long Active { get; set; }

        [JsonProperty("status")]
        [JsonConverter(typeof(LongParseStringConverter))]
        public long Status { get; set; }

        [JsonProperty("board_data")]
        public string BoardData { get; set; }

        [JsonProperty("board_data_org")]
        public string BoardDataOrg { get; set; }

        [JsonProperty("turn")]
        [JsonConverter(typeof(LongParseStringConverter))]
        public long Turn { get; set; }

        [JsonProperty("last_chat_time")]
        public DateTimeOffset LastChatTime { get; set; }

        [JsonProperty("user_list")]
        public List<Player> PlayerList { get; set; }

        [JsonProperty("tiles_left")]
        [JsonConverter(typeof(LongParseStringConverter))]
        public long TilesLeft { get; set; }

        [JsonProperty("tiles_percent")]
        [JsonConverter(typeof(LongParseStringConverter))]
        public long TilesPercent { get; set; }

        [JsonProperty("fails")]
        [JsonConverter(typeof(LongParseStringConverter))]
        public long Fails { get; set; }

        [JsonProperty("swap_count")]
        [JsonConverter(typeof(LongParseStringConverter))]
        public long SwapCount { get; set; }
    }
}
