using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabloOpgave
{
    public class WeaponFactory
    {
        
        
        public List<Weapon> weaponlist = new List<Weapon>();


        public void CreateWeapons()
        {
            Random r = new Random();
            

            for (int i = 0; i < 2; i++)
            {
                int rdmg = r.Next(10) + 1;
                double rspeed = r.Next(10) + 1;
                int rrarity = r.Next(5) + 1;
                weaponlist.Add(new Axe("Axe of " + ElementSelect() + "| ", rdmg, rspeed, rrarity));

                rdmg = r.Next(10) + 1;
                rspeed = r.Next(10) + 1;
                rrarity = r.Next(5) + 1;
                weaponlist.Add(new Scythe("Scythe " + ElementSelect() + "| ", rdmg, rspeed, rrarity));

                rdmg = r.Next(10) + 1;
                rspeed = r.Next(10) + 1;
                rrarity = r.Next(5) + 1;
                weaponlist.Add(new Mighty_Weapon("Mighty Weapon of " + ElementSelect() + "| ", rdmg, rspeed, rrarity));

                rdmg = r.Next(10) + 1;
                rspeed = r.Next(10) + 1;
                rrarity = r.Next(5) + 1;
                weaponlist.Add(new Flail("Flail of " + ElementSelect() + "| ", rdmg, rspeed, rrarity));

                rdmg = r.Next(10) + 1;
                rspeed = r.Next(10) + 1;
                rrarity = r.Next(5) + 1;
                weaponlist.Add(new Fist_Weapon("Fist Weapon of " + ElementSelect() + "| ", rdmg, rspeed, rrarity));


                rdmg = r.Next(10) + 1;
                rspeed = r.Next(10) + 1;
                rrarity = r.Next(5) + 1;
                weaponlist.Add(new Knife("Knife of " + ElementSelect() + "| ", rdmg, rspeed, rrarity));

                rdmg = r.Next(10) + 1;
                rspeed = r.Next(10) + 1;
                rrarity = r.Next(5) + 1;
                weaponlist.Add(new Sword("Sword of " + ElementSelect() + "| ", rdmg, rspeed, rrarity));

                rdmg = r.Next(10) + 1;
                rspeed = r.Next(10) + 1;
                rrarity = r.Next(5) + 1;
                weaponlist.Add(new Mace("Mace of " + ElementSelect() + "| ", rdmg, rspeed, rrarity));

                rdmg = r.Next(10) + 1;
                rspeed = r.Next(10) + 1;
                rrarity = r.Next(5) + 1;
                weaponlist.Add(new Dagger("Dagger of " + ElementSelect() + "| ", rdmg, rspeed, rrarity));

                rdmg = r.Next(10) + 1;
                rspeed = r.Next(10) + 1;
                rrarity = r.Next(5) + 1;
                weaponlist.Add(new Spear("Spear of " + ElementSelect() + "| ", rdmg, rspeed, rrarity));
            }
        }

        private string ElementSelect()
        {
            Random r = new Random();
            int t = r.Next(1, 10);
            switch (t)
            {
                case 1: return "Fire";
                case 2: return "Water";
                case 3: return "Earth";
                case 4: return "Winds";
                case 5: return "Tempest";
                case 6: return "Mountains";
                case 7: return "Nature";
                case 8: return "Death";
                case 9: return "Protection";
                default:
                    return null;
            }
        }

        public void PrintWeapons()
        {
            CreateWeapons();

            foreach (Weapon item in weaponlist)
            {
                Console.WriteLine(item.Name + " " + "Damage: " + item.Atkrange + " " + "Attack Speed: " + item.Atkspeed + " " + "Rarity: " + item.Rarity);
            }
        }
    }
}
