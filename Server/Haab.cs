using Microsoft.AspNetCore.SignalR;

namespace SignalRPrimer.Server
{
    public class Haab : Hub
    {
        public async Task Test(int x, int y)
        {
            Console.WriteLine($"{x} {y}");

            await Clients.Caller.SendAsync("EvoTiZbir", x + y, "zdravooo", x - y);
        }
    }
}