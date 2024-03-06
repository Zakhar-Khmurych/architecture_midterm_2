using System.Collections.Generic;
using Model;

namespace Creatures
{
    public class Wizard : Creature
    {
        public Wizard(Player player)
        { 
            HP = 4;
            AttackPower = 4;
            _Player = player;
            int HealingPower = 1;
            
        }

        void HealEveryone(List<Creature> allies)
        {
            foreach (var ally in allies)
            {
                Target();//targets ally
                Strike();
            }
        }
    }
    
    
}