using System.Collections.Generic;
using Model;

namespace Creatures
{
    public class Troll : Creature
    {
        public Troll(Player player)
        { 
            HP = 10;
            AttackPower = 2;
            _Player = player;
        }

        void DoubleAttack(List<Creature> enemies)
        {
            foreach (var enemy in enemies)
            {
                Target();//targets enemy
                Strike();
            }
            foreach (var enemy in enemies)
            {
                Target();// AGAIN! 
                Strike();// WAAGH!
            }
        }
    }
    
    
}