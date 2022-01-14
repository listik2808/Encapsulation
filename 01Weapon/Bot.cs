using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Weapon
{
    public class Bot
    {
        private readonly Weapon Weapon;

        public Bot(Weapon weapon)
        {
            Weapon = weapon;
        }

        public void OnSeePlayer(Player player)
        {
            if (player.Dead)
                return;

            Weapon.Fire(player);
        }
    }
}
