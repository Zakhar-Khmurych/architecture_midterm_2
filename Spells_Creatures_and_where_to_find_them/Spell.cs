using Model;

namespace Creatures
{
    public abstract class Spell : ISpell
    {
        public int AttackPower;
        public Player _Player;

        public int Strike()
        {
            return AttackPower;
        }
        
        public void Target()
        {
            // will think later about this
        }

    }
}