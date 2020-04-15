using System;
using AltV.Net;
using AltV.Net.Elements.Entities;

namespace AltV
{
    internal class MyResource : Resource
    {
        public override void OnStart()
        {
            Alt.On<IPlayer,string>("myMessage",EventHandler.MyMessageHandler);
            Alt.On<IPlayer>("spawnVehicle",EventHandler.SpawnVehicle);
            //debug
            Alt.OnServerEvent += (name,args) => { Alt.Log(name + " " + args.Length); };
            Alt.OnPlayerEvent += (player,name,args) => { Alt.Log("event:" + name); };
            Console.WriteLine("Started");
        }

       

        public override void OnStop()
        {
            Console.WriteLine("Stopped");
        }
    }
}
