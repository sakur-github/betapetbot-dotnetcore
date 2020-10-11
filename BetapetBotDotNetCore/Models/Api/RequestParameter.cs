using System;
namespace BetapetBotDotNetCore.Models.Api
{
    public class RequestParameter
    {
        public string Key { get; private set; }
        public string Value { get; private set; }

        public RequestParameter(string key, string value)
        {
            Key = key;
            Value = value;
        }
    }
}
