namespace RoleplayGame
{
    public class Enemies: Character
    {
        public Enemies(string name, int victoryPointsValue):base(name)
        {
            this.VictoryPointsValue = victoryPointsValue;
        }

        public int VictoryPointsValue
        {
            get;set;
        }
    }
}