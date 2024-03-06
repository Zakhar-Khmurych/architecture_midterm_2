using System.Collections.Generic;
using Creatures;

namespace PlayerActions
{
    public class PlayerPutCreature() : PlayerActions
    {
        void PutCreature(Creature creature)
        {
            //some EPIC_CREATURE_LIST<Creature> should probably be clother the centre of architecture, but I forgot about it
            List<string> EPIC_CREATURE_LIST = new List<string>();
            EPIC_CREATURE_LIST.Add(creature.ToString());
        }
    }
}