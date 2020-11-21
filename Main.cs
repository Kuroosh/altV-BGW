using AltV.Net;
using AltV.Net.Async;
using AltV.Net.Elements.Entities;
using BGW.Models;

namespace BGW
{
    public class BestGangwar : AsyncResource
    {
        public override void OnStart() { Globals.ScriptEvents.OnResourceStart(); }
        public override void OnStop() { Globals.ScriptEvents.OnResourceStop(); }
        public override IEntityFactory<IPlayer> GetPlayerFactory() { return new MyPlayerFactory(); }
    }
    public class Main
    {

    }
}
