namespace RoleplayGame
{
    public class Heroes: Character
    {
        public Heroes(string name):base(name)
        {
        }

        public int VictoryPoints
        {
            get
            {
                return this.VictoryPoints;
            }
            set 
            {
                this.VictoryPoints = value;
            }
        }

        public void AcumulateVP(Enemies enemy)
        {
            this.VictoryPoints += enemy.VictoryPointsValue;
        }
    }
}