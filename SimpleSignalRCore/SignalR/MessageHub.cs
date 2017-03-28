using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleSignalRCore.SignalR
{

    public class MessageHub:Hub
    {
        public void SendMessage(string Message)
        {
            Clients.All.GetMessage(Message);
        }

        public override Task OnConnected()
        {
            Clients.All.GetMessage(Context.ConnectionId + "connect...");

            return base.OnConnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {

            Clients.All.GetMessage(Context.ConnectionId + "DisConnect");
            return base.OnDisconnected(stopCalled);
        }
    }
}
