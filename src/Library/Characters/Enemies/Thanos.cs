using System.Collections.Generic;
namespace RoleplayGame
{
    public class Thanos: Enemies
    {
        public Thanos(string name, int victoryPointsValue):base(name, victoryPointsValue)
        {
            this.AddItem(new Armor());
            this.AddItem(new Axe());
        }
    }
}