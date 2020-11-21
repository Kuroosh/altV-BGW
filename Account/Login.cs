using BGW.Models;
using System;

namespace BGW.Account
{
    public class Login
    {
        public static void LoginPlayer(GangwarPlayer player)
        {
            try
            {
                AccountModel accClass = Init.GetAccountModelByPlayer(player);
                if (accClass is null) return;
                player.UID = accClass.UID;
                player.Username = accClass.Username;
                player.Deaths = accClass.Deaths;
                player.AdminLevel = accClass.AdminLevel;
                player.Kills = accClass.Kills;
                player.Playtime = accClass.Playtime;
                player.TriggerClientEvent("Selection:Show");
            }
            catch (Exception ex) { Core.Debug.CatchException(ex); }
        }
    }
}
