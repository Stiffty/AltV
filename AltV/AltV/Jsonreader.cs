using System;
using System.IO;
using System.Text.Json;
using AltV.Net;
using AltV.Net.Data;
using AltV.Net.Elements.Entities;

namespace AltV
{
    public class Jsonreader
    {
        public Jsonreader()
        {
            String jsonIn = File.ReadAllText(@"C:\Users\elach\Documents\GitHub\AltV\objectslocations\worldAirMasts.json");
            PostionJson[] postions = JsonSerializer.Deserialize<PostionJson[]>(jsonIn);

            for (int i = 0; i < postions.Length; i++)
            {
                vec3 pos = postions[i].Position;
                Alt.CreateBlip(BlipType.Pickup, new Position(pos.X,pos.Y,pos.Z));
            }
        }
    }

}