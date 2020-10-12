using System;
using BetapetBotDotNetCore.Models.Serialization;
using Newtonsoft.Json;

namespace BetapetBotDotNetCore.Models.Api.Responses.Subclasses
{
    public class User
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(LongParseStringConverter))]
        public long Id { get; set; }

        [JsonProperty("handle")]
        public string Handle { get; set; }

        [JsonProperty("name_first")]
        public string NameFirst { get; set; }

        [JsonProperty("name_last")]
        public string NameLast { get; set; }

        [JsonProperty("age")]
        [JsonConverter(typeof(LongParseStringConverter))]
        public long Age { get; set; }

        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(LongParseStringConverter))]
        public long? Location { get; set; }

        [JsonProperty("gender")]
        [JsonConverter(typeof(LongParseStringConverter))]
        public long Gender { get; set; }

        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        [JsonProperty("avatar")]
        [JsonConverter(typeof(LongParseStringConverter))]
        public long Avatar { get; set; }

        [JsonProperty("avatar_filename")]
        public string AvatarFilename { get; set; }

        [JsonProperty("location_text")]
        public string LocationText { get; set; }

        [JsonProperty("rating")]
        [JsonConverter(typeof(LongParseStringConverter))]
        public long Rating { get; set; }

        [JsonProperty("won")]
        [JsonConverter(typeof(LongParseStringConverter))]
        public long Won { get; set; }

        [JsonProperty("lost")]
        [JsonConverter(typeof(LongParseStringConverter))]
        public long Lost { get; set; }

        [JsonProperty("droped")]
        [JsonConverter(typeof(LongParseStringConverter))]
        public long Droped { get; set; }

        [JsonProperty("drawn")]
        [JsonConverter(typeof(LongParseStringConverter))]
        public long Drawn { get; set; }

        [JsonProperty("games")]
        [JsonConverter(typeof(LongParseStringConverter))]
        public long Games { get; set; }

        [JsonProperty("bingos")]
        [JsonConverter(typeof(LongParseStringConverter))]
        public long Bingos { get; set; }
    }
}
