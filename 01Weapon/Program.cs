using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Weapon
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(10);
            Weapon weapon = new Weapon(5, 5);

            while(player.Dead == false)
            {
                weapon.Fire(player);
            }
        }
    }
}
