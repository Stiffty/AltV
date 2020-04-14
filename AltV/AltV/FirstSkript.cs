using System;
using System.Collections.Generic;
using System.Text;
using AltV.Net;
using AltV.Net.Elements.Entities;
using AltV.Net.Enums;

namespace AltV
{
    class FirstSkript : IScript
    {
        [ScriptEvent(ScriptEventType.PlayerConnect)]
        public void PlayerConnect(IPlayer player,string reason)
        {
            player.SetPosition(-1070.06250f,-2975.122803f,13.773568f);
            player.SetDateTime(DateTime.Now);
            player.Model = ( uint ) PedModel.FreemodeMale01;
            Console.WriteLine(player.Name);
        }
    }
}
