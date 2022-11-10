using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace PingPong
{
    public sealed class Ping
    {
        public EventHandler pingEvent;
        public void AddPongFriend(Pong pong)
        {
            pong.pongEvent += PongReceivedEvent;
        }

        private void PongReceivedEvent(object? sender, EventArgs e)
        {
            Console.WriteLine("Ping received pong");
            Thread.Sleep(1000);
            pingEvent.Invoke(this, EventArgs.Empty);
        }

    }

}
