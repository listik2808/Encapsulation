using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Weapon
{
    public class Player
    {
        private int Health;
        private bool _isDead = false;

        public Player(int health)
        {
            if (health <= 0)
                throw new InvalidOperationException();
            Health = health;
        }

        public bool Dead => _isDead;

        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health <= 0)
                _isDead = true;
        }
    }
}
