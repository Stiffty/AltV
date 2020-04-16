using AltV.Net.Elements.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AltV
{
    class PlayerManager
    {
        public static readonly PlayerManager playerManagerInstance = new PlayerManager();
        private Dictionary<string,Player> players;

        private PlayerManager()
        {
           players = new Dictionary<string, Player>();
        }

        public bool addPlayer(IPlayer player)
        {
            String token = player.AuthToken;

            if ( !players.ContainsKey(token) )
            {
                players.Add(token,new Player(player));
                return true;
            }
            return false;
        }
    }
}
