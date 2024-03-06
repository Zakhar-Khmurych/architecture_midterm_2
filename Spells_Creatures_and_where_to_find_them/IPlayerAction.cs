using System;
using Creatures;

namespace Model
{
    public interface IPlayerAction
    {
        Creature PutCreature();
        Spell CastSpell();
        void ActAsCreature();
        void Attack();
    }
}