using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabloOpgave
{
    public abstract class Weapon
    {

		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private int atkrange;

		public int Atkrange
		{
			get { return atkrange; }
			set { atkrange = value; }
		}

		private double atkspeed;

		public double Atkspeed
		{
			get { return atkspeed; }
			set { atkspeed = value; }
		}

		private int rarity;

		public int Rarity
		{
			get { return rarity; }
			set { rarity = value; }
		}

		public Weapon()
		{
			Name = name;
			Atkrange = atkrange;
			Atkspeed = atkspeed;
			Rarity = rarity;
		}
	}
}
