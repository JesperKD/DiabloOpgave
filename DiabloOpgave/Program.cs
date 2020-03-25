using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabloOpgave
{
    class Program
    {
        static void Main(string[] args)
        {

            WeaponFactory weaponFactory = new WeaponFactory();
            weaponFactory.PrintWeapons();

            Console.ReadKey();
        }
    }
}
