using AltV.Net;
using BGW.Models;

namespace BGW.Globals
{
    public class ClientEvents : IScript
    {
        [ClientEvent("Select:PlayerTeam")]
        public static void SelectPlayerTeam(GangwarPlayer player, int id)
        {
            player.SetTeam(id);
        }

        [ClientEvent("Account:Login")]
        public static void OnPlayerLogin(GangwarPlayer player, string Username)
        {

        }
    }
}
