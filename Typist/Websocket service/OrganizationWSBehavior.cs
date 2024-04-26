using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace Typist.Websocket_service
{
    internal class OrganizationWSBehavior : WebSocketBehavior
    {
        protected override void OnMessage(MessageEventArgs e)
        {
            Sessions.Broadcast(WebsocketService.outgoingText);
            WebsocketService.incomingText = e.Data.ToString().Trim();
        }
    }
}
