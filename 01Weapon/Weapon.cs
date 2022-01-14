using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Weapon
{
    public class Weapon
    {
        public int Damage { get; private set; }
        private int Bullets;

        public Weapon(int damage,int bullets)
        {
            if (damage <= 0)
                throw new InvalidOperationException();
            Damage = damage;

            if (bullets <= 0)
                throw new InvalidOperationException();
            Bullets = bullets;
        }

        public void Fire(Player player)
        {
            player.TakeDamage(Damage);
            Bullets--;
        }
    }
}
