using AltV.Net;
using AltV.Net.Elements.Entities;
using AltV.Net.Enums;
using System;
using System.Numerics;

namespace BGW.Models
{
    public class GangwarPlayer : Player
    {
        public int UID { get; set; }
        public string Username { get; set; }
        public int AdminLevel { get; set; }
        public int Kills { get; set; }
        public int Deaths { get; set; }
        public int Playtime { get; set; }
        public void SetPosition(Vector3 pos) => Alt.Emit("GlobalSystems:PlayerPosition", this, pos);
        public void SetTeam(int Team) => Alt.Emit("GlobalSystems:PlayerTeam", this, Team);
        public void GiveWeapon(WeaponModel WeaponModel, int Ammo) => Alt.Emit("GlobalSystems:GiveWeapon", this, (uint)WeaponModel, Ammo);
        public void RemoveWeapon(WeaponModel WeaponModel) => Alt.Emit("GlobalSystems:RemovePlayerWeapon", this, (uint)WeaponModel);
        public void RemoveWeapon() => Alt.Emit("GlobalSystems:RemoveAllPlayerWeapons", this);
        public void TriggerClientEvent(string EventName, params object[] args) => Alt.Server.TriggerClientEvent(this, EventName, args);
        public void SetClothes(int clothesslot, int clothesdrawable, int clothestexture) => Alt.Server.TriggerClientEvent(this, "Clothes:Load", clothesslot, clothesdrawable, clothestexture);
        public void SetProp(int propID, int drawableID, int textureID) => Alt.Server.TriggerClientEvent(this, "Prop:Load", propID, drawableID, textureID);
        public void Notify(string msg) => Alt.Server.TriggerClientEvent(this, "Notify:Create", msg);
        public GangwarPlayer(IntPtr nativePointer, ushort id) : base(nativePointer, id)
        {
        }
    }
    public class MyPlayerFactory : IEntityFactory<IPlayer>
    {
        public IPlayer Create(IntPtr playerPointer, ushort id)
        {
            return new GangwarPlayer(playerPointer, id);
        }
    }
}
