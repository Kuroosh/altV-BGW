using BGW.Models;
using System.Collections.Generic;

namespace BGW.Account
{
    public class Init
    {
        public static List<AccountModel> AccountList = new List<AccountModel>();

        public static AccountModel GetAccountModelByPlayer(GangwarPlayer player)
        {
            foreach (AccountModel accClass in AccountList)
                if (accClass.HardwareIdHash == player.HardwareIdHash.ToString() || accClass.SocialClubId == player.SocialClubId.ToString()) return accClass;

            return null;
        }
    }
}
