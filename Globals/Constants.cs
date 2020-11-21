using AltV.Net;
using BGW.Models;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace BGW.Globals
{
    public class Constants
    {
        /* Teams */
        public enum Teams
        {
            LSPD = 1,
            LCN = 2,
            YAKUZA = 3,
            FIB = 6,
            NARCOS = 7,
            USARMY = 8,
            SAMCRO = 9,
            ROLLINHEIGHTS = 12,
            COMPTONFAMILYS = 13
        }
        /* Admin Levels */
        public enum AdminLevels
        {
            None = 0,
            Supporter = 1,
            Moderator = 2,
            Administrator = 3
        }

        /* Ban Types */
        public const string BANTYPE_TIMEBAN = "Timeban";
        public const string BANTYPE_PERMABAN = "Permanent";

        /* Player Spawnpoints */
        public static Dictionary<int, Vector3> PlayerSpawnpoints = new Dictionary<int, Vector3>
        {
            { (int)Teams.LSPD, new Vector3(428.24176f, -980.8088f, 30.69519f) },
            { (int)Teams.LCN, new Vector3(-1038.044f, 222.168f, 64.37566f) },
            { (int)Teams.YAKUZA, new Vector3(-1516.701f, 851.7410f, 181.5947f) },
            { (int)Teams.FIB, new Vector3(77.02418f, -739.2659f, 45.08496f) },
            { (int)Teams.NARCOS, new Vector3(-1549.369f, -91.01895f, 54.92917f) },
            { (int)Teams.USARMY, new Vector3(-1108.0088f, -845.0901f, 19.30481f) },
            { (int)Teams.SAMCRO, new Vector3(982.0083f, -100.8747f, 74.84512f) },
            { (int)Teams.ROLLINHEIGHTS, new Vector3(-204.68571f, -1604.1758f, 34.823486f) },
            { (int)Teams.COMPTONFAMILYS, new Vector3(126.6941f, -1930.021f, 21.38243f) },
        };

        /* Vehicle Spawnpoints */
        public static Dictionary<int, Vector3> VehicleSpawnpoints = new Dictionary<int, Vector3>
        {
            { (int)Teams.LSPD, new Vector3(408.8835f, -980.0571f, 29.263062f) },
            { (int)Teams.LCN, new Vector3(-1045.4901f, 207.87692f,63.046875f) },
            { (int)Teams.YAKUZA, new Vector3(-1518.6461f,865.1868f,181.6864f) },
            { (int)Teams.FIB, new Vector3(48.356045f,-730.1934f,44.309937f) },
            { (int)Teams.NARCOS, new Vector3(-1542.5406f,-79.22637f,54.1333f) },
            { (int)Teams.USARMY, new Vector3(-1128.7517f, -816.9099f, 15.901123f) },
            { (int)Teams.SAMCRO, new Vector3(979.4242f,-114.56703f,74.23511f) },
            { (int)Teams.ROLLINHEIGHTS, new Vector3(-188.88791f, -1610.5187f,33.8125f) },
            { (int)Teams.COMPTONFAMILYS, new Vector3(114.10549f,-1933.5692f,20.619019f) },
        };

        /* Vehicle Level - Rewards */
        public static Dictionary<int, AltV.Net.Enums.VehicleModel> VehicleLevelList = new Dictionary<int, AltV.Net.Enums.VehicleModel>
        {
            {   1, AltV.Net.Enums.VehicleModel.Voodoo },
            {   2, AltV.Net.Enums.VehicleModel.Felon },
            {   3, AltV.Net.Enums.VehicleModel.Jackal },
            {   4, AltV.Net.Enums.VehicleModel.F620 },
            {   5, AltV.Net.Enums.VehicleModel.Oracle2 },
            {   6, AltV.Net.Enums.VehicleModel.Sultan2 },
            {   7, AltV.Net.Enums.VehicleModel.Sultan },
            {   8, AltV.Net.Enums.VehicleModel.Tulip },
            {   9, AltV.Net.Enums.VehicleModel.Drafter },
            {   10, AltV.Net.Enums.VehicleModel.Comet2 },
            {   11, AltV.Net.Enums.VehicleModel.Kuruma },
            {   12, AltV.Net.Enums.VehicleModel.Buffalo },
            {   13, AltV.Net.Enums.VehicleModel.Cheetah2 },
            {   14, AltV.Net.Enums.VehicleModel.Kamacho },
            {   15, AltV.Net.Enums.VehicleModel.Brawler },
            {   16, AltV.Net.Enums.VehicleModel.Bati },
            {   17, AltV.Net.Enums.VehicleModel.Dominator3 },
            {   18, AltV.Net.Enums.VehicleModel.Jester },
            {   19, AltV.Net.Enums.VehicleModel.Elegy },
            {   20, AltV.Net.Enums.VehicleModel.Marshall },
            {   21, AltV.Net.Enums.VehicleModel.Hakuchou },
            {   22, AltV.Net.Enums.VehicleModel.Caracara2 },
            {   23, AltV.Net.Enums.VehicleModel.Voltic },
            {   24, AltV.Net.Enums.VehicleModel.Infernus },
            {   25, AltV.Net.Enums.VehicleModel.Ninef },
            {   26, AltV.Net.Enums.VehicleModel.Komoda },
            {   27, AltV.Net.Enums.VehicleModel.Imorgon },
            {   28, AltV.Net.Enums.VehicleModel.Schafter2 },
            {   29, AltV.Net.Enums.VehicleModel.Schafter3 },
            {   30, AltV.Net.Enums.VehicleModel.Emerus },
            {   31, AltV.Net.Enums.VehicleModel.Cyclone },
            {   32, AltV.Net.Enums.VehicleModel.Reaper },
            {   33, AltV.Net.Enums.VehicleModel.Tempesta },
            {   34, AltV.Net.Enums.VehicleModel.Taipan },
            {   35, AltV.Net.Enums.VehicleModel.Vagner },
            {   36, AltV.Net.Enums.VehicleModel.Visione },
            {   37, AltV.Net.Enums.VehicleModel.T20 },
            {   38, AltV.Net.Enums.VehicleModel.Xa21 },
            {   39, AltV.Net.Enums.VehicleModel.Prototipo },
            {   40, AltV.Net.Enums.VehicleModel.Thrax },
        };


        public static void GiveRandomHair(GangwarPlayer playerClass)
        {
            try
            {
                Random random = new Random();
                int randomid = random.Next(0, 18);
                switch (randomid)
                {
                    case 0:
                        playerClass.SetClothes(2, 6, 4);
                        break;
                    case 1:
                        playerClass.SetClothes(2, 7, 4);
                        break;
                    case 2:
                        playerClass.SetClothes(2, 2, 3);
                        break;
                    case 3:
                        playerClass.SetClothes(2, 2, 4);
                        break;
                    case 4:
                        playerClass.SetClothes(2, 14, 4);
                        break;
                    case 5:
                        playerClass.SetClothes(2, 25, 3);
                        break;
                    case 7:
                        playerClass.SetClothes(2, 38, 4);
                        break;
                    case 8:
                        playerClass.SetClothes(2, 57, 3);
                        break;
                    case 9:
                        playerClass.SetClothes(2, 57, 4);
                        break;
                    case 10:
                        playerClass.SetClothes(2, 72, 3);
                        break;
                    case 11:
                        playerClass.SetClothes(2, 72, 4);
                        break;
                    case 12:
                        playerClass.SetClothes(2, 74, 3);
                        break;
                    case 13:
                        playerClass.SetClothes(2, 54, 4);
                        break;
                    case 14:
                        playerClass.SetClothes(2, 32, 4);
                        break;
                    case 15:
                        playerClass.SetClothes(2, 32, 3);
                        break;
                    case 16:
                        playerClass.SetClothes(2, 8, 4);
                        break;
                    case 17:
                        playerClass.SetClothes(2, 8, 2);
                        break;
                    case 18:
                        playerClass.SetClothes(2, 8, 2);
                        break;
                }
            }
            catch (Exception ex) { Core.Debug.CatchException(ex); }
        }


        public static void LoadGangSkin(GangwarPlayer playerClass, int Gang)
        {
            try
            {
                playerClass.Model = Alt.Hash("mp_m_freemode_01");
                playerClass.SetClothes(0, 0, 0);
                playerClass.SetClothes(1, 0, 0);
                playerClass.SetClothes(2, 0, 0);
                playerClass.SetClothes(3, 0, 0);
                playerClass.SetClothes(4, 0, 0);
                playerClass.SetClothes(5, 0, 0);
                playerClass.SetClothes(6, 0, 0);
                playerClass.SetClothes(7, 0, 0);
                playerClass.SetClothes(8, 0, 0);
                playerClass.SetClothes(9, 0, 0);
                playerClass.SetClothes(10, 0, 0);
                playerClass.SetClothes(11, 0, 0);
                GiveRandomHair(playerClass);
                switch (Gang)
                {
                    case (int)Teams.LSPD:
                        playerClass.SetClothes(0, 0, 0);
                        playerClass.SetClothes(1, 0, 0);
                        playerClass.SetClothes(2, -1, -1);
                        playerClass.SetClothes(3, 0, 0);
                        playerClass.SetClothes(4, 35, 0);
                        playerClass.SetClothes(5, 0, 0);
                        playerClass.SetClothes(6, 25, 0);
                        playerClass.SetClothes(7, 0, 0);
                        playerClass.SetClothes(8, 58, 0);
                        playerClass.SetClothes(9, 0, 0);
                        playerClass.SetClothes(10, 0, 0);
                        playerClass.SetClothes(11, 55, 0);
                        break;
                    case (int)Teams.LCN:
                        playerClass.SetClothes(0, 0, 0);
                        playerClass.SetClothes(1, 0, 0);
                        playerClass.SetClothes(2, -1, -1);
                        playerClass.SetClothes(3, 4, 0);
                        playerClass.SetClothes(4, 28, 0);
                        playerClass.SetClothes(5, 0, 0);
                        playerClass.SetClothes(6, 21, 0);
                        playerClass.SetClothes(7, 0, 0);
                        playerClass.SetClothes(8, 33, 0);
                        playerClass.SetClothes(9, 0, 0);
                        playerClass.SetClothes(10, 0, 0);
                        playerClass.SetClothes(11, 29, 0);
                        break;
                    case (int)Teams.YAKUZA:
                        playerClass.SetClothes(2, -1, -1);
                        playerClass.SetClothes(5, 0, 0);
                        playerClass.SetClothes(7, 0, 0);
                        playerClass.SetClothes(8, 15, 0);
                        playerClass.SetClothes(9, 0, 0);
                        playerClass.SetClothes(10, 0, 0);
                        playerClass.SetClothes(0, 0, 0);
                        playerClass.SetClothes(1, -1, 0);
                        playerClass.SetClothes(11, 107, 2);
                        playerClass.SetClothes(3, 33, 0);
                        playerClass.SetClothes(4, 33, 0);
                        playerClass.SetClothes(6, 81, 0);
                        break;
                    case (int)Teams.FIB:
                        playerClass.SetClothes(0, -1, -1);
                        playerClass.SetClothes(1, 0, 0);
                        playerClass.SetClothes(2, -1, -1);
                        playerClass.SetClothes(3, 11, 0);
                        playerClass.SetClothes(4, 10, 0);
                        playerClass.SetClothes(5, -1, -1);
                        playerClass.SetClothes(6, 10, 0);
                        playerClass.SetClothes(7, 12, 2);
                        playerClass.SetClothes(8, 15, 0);
                        playerClass.SetClothes(9, 0, 0);
                        playerClass.SetClothes(10, -1, 0);
                        playerClass.SetClothes(11, 13, 0);
                        break;
                    case (int)Teams.NARCOS:
                        playerClass.SetClothes(0, 8, -1);
                        playerClass.SetClothes(1, 0, 0);
                        playerClass.SetClothes(2, -1, -1);
                        playerClass.SetClothes(3, 11, 0);
                        playerClass.SetClothes(4, 22, 0);
                        playerClass.SetClothes(5, 0, -1);
                        playerClass.SetClothes(6, 21, 5);
                        playerClass.SetClothes(7, 0, 0);
                        playerClass.SetClothes(8, 15, 0);
                        playerClass.SetClothes(9, 0, 0);
                        playerClass.SetClothes(10, 0, 0);
                        playerClass.SetClothes(11, 13, 1);
                        break;
                    case (int)Teams.USARMY:
                        playerClass.SetClothes(4, 86, 8);
                        playerClass.SetClothes(11, 220, 8);
                        playerClass.SetClothes(8, 130, 0);
                        playerClass.SetClothes(6, 24, 0);
                        playerClass.SetClothes(2, 2, 4);
                        playerClass.SetProp(0, 107, 8);
                        break;
                    case (int)Teams.SAMCRO:
                        playerClass.SetClothes(0, -1, -1);
                        playerClass.SetClothes(1, 0, 0);
                        playerClass.SetClothes(2, -1, -1);
                        playerClass.SetClothes(3, 2, 0);
                        playerClass.SetClothes(4, 76, 1);
                        playerClass.SetClothes(5, -1, -1);
                        playerClass.SetClothes(6, 25, 0);
                        playerClass.SetClothes(7, 0, 0);
                        playerClass.SetClothes(8, 14, 0);
                        playerClass.SetClothes(9, 0, 0);
                        playerClass.SetClothes(10, -1, 0);
                        playerClass.SetClothes(11, 175, 3);
                        break;
                    case (int)Teams.ROLLINHEIGHTS:
                        playerClass.SetClothes(11, 306, 9);
                        playerClass.SetClothes(8, 15, 0);
                        playerClass.SetClothes(6, 26, 0);
                        playerClass.SetClothes(4, 31, 0);
                        playerClass.SetClothes(1, 111, 2);
                        playerClass.SetClothes(3, 4, 0);
                        break;
                    case (int)Teams.COMPTONFAMILYS:
                        playerClass.SetClothes(1, 111, 0);
                        playerClass.SetClothes(3, 4, 0);
                        playerClass.SetClothes(4, 31, 0);
                        playerClass.SetClothes(6, 7, 0);
                        playerClass.SetClothes(11, 143, 0);
                        playerClass.SetClothes(8, 15, 0);
                        break;
                }
            }
            catch { }
        }

        public static void GivePlayerGangwarWeapons(GangwarPlayer player)
        {
            try
            {
                player.GiveWeapon(AltV.Net.Enums.WeaponModel.DoubleActionRevolver, 9999);
                player.GiveWeapon(AltV.Net.Enums.WeaponModel.HeavyRevolverMkII, 9999);
                player.GiveWeapon(AltV.Net.Enums.WeaponModel.Pistol50, 9999);
                player.GiveWeapon(AltV.Net.Enums.WeaponModel.MiniSMG, 9999);
                player.GiveWeapon(AltV.Net.Enums.WeaponModel.SMG, 9999);
                player.GiveWeapon(AltV.Net.Enums.WeaponModel.PumpShotgun, 9999);
                player.GiveWeapon(AltV.Net.Enums.WeaponModel.Musket, 9999);
                player.GiveWeapon(AltV.Net.Enums.WeaponModel.APPistol, 9999);
                player.GiveWeapon(AltV.Net.Enums.WeaponModel.CombatPDW, 9999);
                player.GiveWeapon(AltV.Net.Enums.WeaponModel.BullpupRifle, 9999);
                player.GiveWeapon(AltV.Net.Enums.WeaponModel.AdvancedRifle, 9999);
                player.GiveWeapon(AltV.Net.Enums.WeaponModel.GusenbergSweeper, 9999);
                player.GiveWeapon(AltV.Net.Enums.WeaponModel.AssaultRifle, 9999);
                player.GiveWeapon(AltV.Net.Enums.WeaponModel.SpecialCarbine, 9999);
                player.GiveWeapon(AltV.Net.Enums.WeaponModel.Switchblade, 9999);
                player.GiveWeapon(AltV.Net.Enums.WeaponModel.Nightstick, 9999);
                player.GiveWeapon(AltV.Net.Enums.WeaponModel.Machete, 9999);
                player.GiveWeapon(AltV.Net.Enums.WeaponModel.BaseballBat, 9999);
            }
            catch { }
        }
        public static void LoadGangVehicleSpawnpoints(GangwarPlayer playerClass)
        {
            try
            {
                foreach (Vector3 vehClasses in VehicleSpawnpoints.Values)
                {
                    playerClass.Emit("TextLabel:Create", "Press ~b~E ~w~to select a Vehicle.", vehClasses.X, vehClasses.Y, vehClasses.Z, 0, 255, 255, 255, 40);
                }
            }
            catch { }
        }
        public static void LoadGangAreas(GangwarPlayer playerClass)
        {
            try
            {
                foreach (var ZonePosition in PlayerSpawnpoints)
                {
                    switch (ZonePosition.Key)
                    {
                        case (int)Teams.LSPD:
                            playerClass.Emit("Zone:Create", ZonePosition.Key, ZonePosition.Value.X, ZonePosition.Value.Y, ZonePosition.Value.Z, 100, 3, 0);
                            break;
                        case (int)Teams.LCN:
                            playerClass.Emit("Zone:Create", ZonePosition.Key, ZonePosition.Value.X, ZonePosition.Value.Y, ZonePosition.Value.Z, 100, 55, 0);
                            break;
                        case (int)Teams.YAKUZA:
                            playerClass.Emit("Zone:Create", ZonePosition.Key, ZonePosition.Value.X, ZonePosition.Value.Y, ZonePosition.Value.Z, 100, 1, 0);
                            break;
                        case (int)Teams.FIB:
                            playerClass.Emit("Zone:Create", ZonePosition.Key, ZonePosition.Value.X, ZonePosition.Value.Y, ZonePosition.Value.Z, 100, 63, 0);
                            break;
                        case (int)Teams.NARCOS:
                            playerClass.Emit("Zone:Create", ZonePosition.Key, ZonePosition.Value.X, ZonePosition.Value.Y, ZonePosition.Value.Z, 100, 45, 0);
                            break;
                        case (int)Teams.USARMY:
                            playerClass.Emit("Zone:Create", ZonePosition.Key, ZonePosition.Value.X, ZonePosition.Value.Y, ZonePosition.Value.Z, 100, 69, 0);
                            break;
                        case (int)Teams.SAMCRO:
                            playerClass.Emit("Zone:Create", ZonePosition.Key, ZonePosition.Value.X, ZonePosition.Value.Y, ZonePosition.Value.Z, 100, 56, 0);
                            break;
                        case (int)Teams.ROLLINHEIGHTS:
                            playerClass.Emit("Zone:Create", ZonePosition.Key, ZonePosition.Value.X, ZonePosition.Value.Y, ZonePosition.Value.Z, 100, 27, 0);
                            break;
                    }
                }

            }
            catch { }
        }
    }
}