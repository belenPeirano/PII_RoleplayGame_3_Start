
namespace RolePlayGame
{
    public class Encounter
    {
        private List<Enemies> enemyList = new List<Enemies>();

        private List<Heroes> heroList = new List<Heroes>();

        public Encounter(Heroes Hero, Enemies Enemy)//Agrega a la lista los heroes y enemigos que comienzan en la batalla
        {
            enemyList.Add(Enemy); 
            heroList.Add(Hero); 
        }

        public void AddEnemy(Enemies Enemy) //Agrega enemigos extra a la batalla
        {
            enemyList.Add(Enemy);
        }

        public void AddHero(Herores Hero) //Agrega heroes extra a la batalla
        {
            heroList.Add(Hero);
        }

        private void EnAttack()
        {
            counter = 0;
            foreach (Enemies enemy in enemyList)
            {
                heroList[counter].ReceiveAttack(enemy.AttackValue);
                counter += 1;

                if (counter >= heroList.Count)
                {
                    counter = 0;
                }
            }
        }

        private void HerAttack()
        {
            
        }

        public void DoEncounter()
        {

        }

        
    }
}