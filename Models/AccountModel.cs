namespace BGW.Models
{
    public class AccountModel
    {
        public int UID { get; set; }
        public string Username { get; set; }
        public string HardwareIdHash { get; set; }
        public string SocialClubId { get; set; }
        public int AdminLevel { get; set; }
        public int Kills { get; set; }
        public int Deaths { get; set; }
        public int Playtime { get; set; }
    }
}
