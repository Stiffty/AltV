using System;
using AltV.Net;

namespace AltV
{
    internal class MyResource : Resource
    {
        public override void OnStart()
        {
            Console.WriteLine("Started");
        }

        public override void OnStop()
        {
            Console.WriteLine("Stopped");
        }
    }
}
