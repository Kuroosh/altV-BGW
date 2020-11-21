using AltV.Net;
using AltV.Net.Resources.Chat.Api;
using BGW.Models;
using System.Drawing;
using System.Linq;

namespace BGW.Globals
{
    public class Functions
    {
        public static GangwarPlayer GetPlayerByName(string Username)
        {
            foreach (GangwarPlayer player in Alt.GetAllPlayers().ToList())
                if (player is not null && player.Exists && player.Username == Username) return player;
            return null;
        }

        public static void SendChatMessageToAll(string text)
        {
            foreach (GangwarPlayer player in Alt.GetAllPlayers().ToList())
                if (player is not null && player.Exists) player?.SendChatMessage(text);
        }

        public static string GetHexColorcode(int r, int g, int b)
        {
            Color myColor = Color.FromArgb(r, g, b);
            return "{" + myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2") + "}";
        }
    }
}
