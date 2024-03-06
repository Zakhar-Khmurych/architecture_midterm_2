using Model;

namespace Creatures
{
    public class Scorpion : Creature
    {
        public Scorpion(Player player)
        { 
            HP = 1;
            AttackPower = 3;
            _Player = player;
        }

        void StrongAttack()
        {
            Target(); // will just hit same creature twice
            Strike();
            Strike();
        }
    }
}