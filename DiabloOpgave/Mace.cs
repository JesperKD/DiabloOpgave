using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabloOpgave
{
    public class Mace : Weapon
    {
        public Mace(string name, int atkrange, double atkspeed, int rarity)
        {
            Name = name;
            Atkrange = atkrange;
            Atkspeed = atkspeed;
            Rarity = rarity;
        }
    }
}
