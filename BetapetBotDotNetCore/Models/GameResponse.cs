using System;
using BetapetBotDotNetCore.Models.Api.Responses;

namespace BetapetBotDotNetCore.Models
{
    public class GameResponse
    {
        public LoginResponse LoginStatus { get; private set; }

        public GameResponse(LoginResponse loginStatus)
        {
            LoginStatus = loginStatus;
        }
    }
}
