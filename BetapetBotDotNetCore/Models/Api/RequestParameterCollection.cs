using System;
using System.Collections.Generic;
using System.Text;

namespace BetapetBotDotNetCore.Models.Api
{
    public class RequestParameterCollection
    {
        private List<RequestParameter> parameters;

        public RequestParameterCollection(bool useDefaultParameters = true)
        {
            parameters = new List<RequestParameter>();

            if (useDefaultParameters)
            {
                AddParameter(new RequestParameter("proto_ver", "5"));
                AddParameter(new RequestParameter("device_type", "2"));
            }
        }

        public void AddParameter(RequestParameter parameter)
        {
            parameters.Add(parameter);
        }

        public void AddParameter(string key, string value)
        {
            parameters.Add(new RequestParameter(key, value));
        }

        public void AddParameter(string key, object value)
        {
            parameters.Add(new RequestParameter(key, value.ToString()));
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder("?");

            foreach (RequestParameter parameter in parameters)
            {
                result.Append(parameter.Key);
                result.Append("=");
                result.Append(parameter.Value);
                result.Append("&");
            }

            result.Remove(result.Length - 1, 1);

            return result.ToString();
        }
    }
}
