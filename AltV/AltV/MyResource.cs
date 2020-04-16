using System;
using AltV.Net;
using AltV.Net.Elements.Entities;

namespace AltV
{
    internal class MyResource : Resource
    {
        public override void OnStart()
        {
            regCustomEvents();
            //debug
            Alt.OnServerEvent += (name,args) => { Alt.Log(name + " " + args.Length); };
            Alt.OnPlayerEvent += (player,name,args) => { Alt.Log("event:" + name); };
            Console.WriteLine("Started");
        }

       

        public override void OnStop()
        {
            Console.WriteLine("Stopped");
        }

        private void regCustomEvents()
        {
            Alt.On<IPlayer>("spawnVehicle",EventHandler.SpawnVehicle);
        }
    }
}
