using System.Collections.Generic;
using Model;

namespace Creatures
{
    public class Heal : Spell
    {
        Heal(Player player)
        {
            AttackPower = -3;
        }

        private List<Creature> THIS_PLAYER_CREATURES;

        void heal()
        {
            foreach (var creature in THIS_PLAYER_CREATURES)
            {
                Target(); // target creature
                Strike(); // heal creature
            }
        }
    }
}