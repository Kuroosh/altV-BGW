using AltV.Net;
using AltV.Net.Resources.Chat.Api;
using BGW.Globals;
using BGW.Models;

namespace BGW.Admin
{
    public class Commands : IScript
    {

        [Command("goto")]
        public static void GoToTarget(GangwarPlayer player, string Username)
        {
            GangwarPlayer target = Functions.GetPlayerByName(Username);
            if (target is null || !target.Exists) return;
            player.SetPosition(target.Position);
        }
        [Command("gethere")]
        public static void GetHereTarget(GangwarPlayer player, string Username)
        {
            GangwarPlayer target = Functions.GetPlayerByName(Username);
            if (target is null || !target.Exists) return;
            target.SetPosition(player.Position);
        }
        [Command("ban")]
        public static void BanTarget(GangwarPlayer player, string Username, string Reason)
        {

            GangwarPlayer target = Functions.GetPlayerByName(Username);
            if (target is null || !target.Exists) { }
            foreach (AccountModel account in Account.Init.AccountList)
                if (account.Username == Username)
                {
                    BanModel newBanEntry = new BanModel
                    {
                        UID = account.UID,
                        HardwareId = account.HardwareIdHash,
                        SCID = account.SocialClubId,
                        Reason = Reason
                    };
                    Database.Database.CreateNewBanEntry(newBanEntry);
                    Admin.Init.AccountBans.Add(newBanEntry);
                    Functions.SendChatMessageToAll(Functions.GetHexColorcode(200, 0, 0) + Username + " got banned! Reason: " + Reason);
                }
        }
    }
}
