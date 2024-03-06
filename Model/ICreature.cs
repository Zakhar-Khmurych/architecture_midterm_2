namespace Model
{
    public interface ICreature
    {
        int Strike();
        void GetStruck(int damage);
        void Target();
        void Die();
    }

    public interface ISpell
    {
        int Strike();
        void Target();
    }
}