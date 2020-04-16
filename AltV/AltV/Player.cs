using AltV.Net.Elements.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AltV
{
    class Player
    {
        private const int INV_SIZE_I = 9;

        private IPlayer player;

        private Dictionary<int,Item> inventar;
        private Dictionary<int,Item> kofferraum;

        public Player(IPlayer player)
        {
            inventar = new Dictionary<int,Item>();
            kofferraum = new Dictionary<int,Item>();
            this.player = player;
        }

        /** 
         * @param inventar Wird ins Inventar hinzugefügt wenn true sonst in Kofferraum
         * @return true wenn erfolgreich wenn nicht false
         * */
        public bool addItem(bool inventar,int index,Item item) 
        {
            if ( inventar && index <=INV_SIZE_I )
            {
                this.inventar.Add(index,item);
                return true;
            }else if( index <= INV_SIZE_I )
            {
                this.kofferraum.Add(index,item);
                return true;
            }
            return false;
        }

        public bool removeItem(bool inventar,int index)
        {
            if ( inventar && index <= INV_SIZE_I )
            {
                this.inventar.Remove(index);
                return true;
            }
            else if ( index <= INV_SIZE_I )
            {
                this.kofferraum.Remove(index);
                return true;
            }
            return false;
        }
    }
}
