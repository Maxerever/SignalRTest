﻿using Microsoft.AspNetCore.SignalR;

namespace SignalRTest
{
    public class ChatHub:Hub
    {
        public async Task Send(string message, string userName)
        {
            await this.Clients.All.SendAsync("Receive", message, userName);
        }
    }
}
