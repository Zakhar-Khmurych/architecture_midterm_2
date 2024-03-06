using Model;

namespace Creatures
{
    public abstract class Creature : ICreature
    {
        public int HP;
        public int AttackPower;
        public Player _Player;

        public Creature(int hp, int ap, Player player)
        {
            HP = hp;
            AttackPower = ap;
            _Player = player;
        }
        
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
        }

        public void Die()
        {
            
        }
    }
}