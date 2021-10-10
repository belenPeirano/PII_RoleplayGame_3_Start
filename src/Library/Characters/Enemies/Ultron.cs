using System.Collections.Generic;
namespace RoleplayGame
{
    public class Ultron: Enemies
    {
        public Ultron(string name, int victoryPointsValue):base(name, victoryPointsValue)
        {
            this.AddItem(new Bow());
            this.AddItem(new Axe());
        }
    }
}