using System.Net.NetworkInformation;

namespace PingPong
{
    public sealed class Pong
    {
        public EventHandler pongEvent;
        public void AddPingFriend(Ping ping)
        {
            ping.pingEvent += PingReceivedEvent;
        }

        private void PingReceivedEvent(object? sender, EventArgs e)
        {
            Console.WriteLine("Pong received ping");
            Thread.Sleep(1000);
            pongEvent.Invoke(this, EventArgs.Empty);
        }
    }

}
