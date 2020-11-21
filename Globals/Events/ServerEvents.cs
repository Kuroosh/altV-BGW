using AltV.Net;
using AltV.Net.Resources.Chat.Api;
using BGW.Models;

namespace BGW.Globals
{
    public class ServerEvents
    {
        [ServerEvent("GlobalSystems:OnVPNConnect")]
        public void OnVPNConnect(GangwarPlayer player, string IP, string CountryCode, string CountryName, string Asn, string Isp)
        {
            player?.Kick("Bro... VPN isn't allowed on our Server!");
        }

        [ServerEvent("GlobalSystems:PlayerReady")]
        public void PlayerConnect(GangwarPlayer player)
        {
            // ShowYourLoginWindow or something else...
        }

        [ServerEvent("GlobalSystems:OnPlayerSyncDamage")]
        public void OnPlayerSyncDamage(GangwarPlayer player, GangwarPlayer killer, float Damage = 0)
        {
            player?.SendChatMessage("Oh... you got hitted by " + killer?.Name);
            killer?.SendChatMessage("Damn boi... You hitted " + player?.Name);
        }
    }
}
