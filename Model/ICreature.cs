namespace Model
{
    public interface ICreature
    {
        int Strike();
        void GetStruck(int damage);
        void Target(); // i wanted to target type <T> or type Creature, but dont know how to implement without Google, ChatGPT or lectures
        void Die();//some EPIC_CREATURE_LIST<Creature> should probably be clother the centre of architecture, but I forgot about it

    }

    public interface ISpell
    {
        int Strike();
        void Target(); // same here
    }
}