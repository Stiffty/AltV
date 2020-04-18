using System;
using System.Collections.Generic;
using System.Text;
using AltV.Net;
using AltV.Net.Data;
using AltV.Net.Elements.Entities;
using AltV.Net.Enums;

namespace AltV
{
    class EventHandler : IScript
    {
        private static PlayerManager playerManager = PlayerManager.playerManagerInstance;

        [ScriptEvent(ScriptEventType.PlayerConnect)]
        public static void PlayerConnect(IPlayer player,string reason)
        {
            player.SetPosition(-1070.06250f,-2975.122803f,13.773568f);
            player.SetDateTime(DateTime.Now);
            player.Model = ( uint ) PedModel.Eastsa02AFY;

            playerManager.addPlayer(player);
            new Jsonreader();
            Console.WriteLine($"New Player joined: {player.Name}");
        }

        public static void SpawnVehicle(IPlayer player)
        {
            string VehicleName = "scramjet";
            Alt.CreateVehicle(Alt.Hash(VehicleName), new Position(player.Position.X, player.Position.Y + 1.5f, player.Position.Z), player.Rotation);
        }

        public static void SendInventory(IPlayer player)
        {
        }
    }
}
