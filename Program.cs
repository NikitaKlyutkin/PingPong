using PingPong;

Ping ping1 = new Ping();
Pong pong1 = new Pong();
ping1.AddPongFriend(pong1);
pong1.AddPingFriend(ping1);

ping1.pingEvent.Invoke(null, EventArgs.Empty);