using System;
using Model;

namespace Creatures
{
    public abstract class Creature : ICreature
    {
        public int HP;
        public int AttackPower;
        public Player _Player;
        
        public int Strike()
        {
            return AttackPower;
        }

        public void GetStruck(int damage)
        {
            HP -= damage;
        }

        public void Target()
        {
            // will think later about this
            // stuck on ICreature
        }

        public void Die()
        {
            if (HP < 0)
            {
                //some EPIC_CREATURE_LIST<Creature> should probably be clother the centre of architecture, but I forgot about it
                //EPIC_CREATURE_LIST.Remove(this);
            }
        }
    }
}