using System.Collections.Generic;

namespace Model
{
    public class Field
    {
        public List<Player> Players;

        public Field()
        {
            
        }

        public void InsertPlayer(Player player)
        {
            Players.Add(player);
        }
    }
}