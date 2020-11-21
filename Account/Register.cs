using BGW.Models;

namespace BGW.Account
{
    public class Register
    {
        public static void RegisterPlayer(GangwarPlayer player, string Username)
        {
            AccountModel accClass = Init.GetAccountModelByPlayer(player);
            if (accClass is not null) return;
            AccountModel newAccClass = new AccountModel
            {
                UID = (Init.AccountList.Count + 1),
                Username = Username,
                AdminLevel = 0,
                Deaths = 0,
                Kills = 0,
                Playtime = 0,
                SocialClubId = player.SocialClubId.ToString(),
                HardwareIdHash = player.HardwareIdHash.ToString()
            };

            Init.AccountList.Add(newAccClass);
            Database.Database.RegisterAccount(Username, player.SocialClubId.ToString(), player.HardwareIdHash.ToString());
        }
    }
}
