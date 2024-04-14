public class EnemyCharacter : Character
{
    private Random Generator = new Random();

    private bool isAlive = true;

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------

    public void RandomEnemyWeapon()
    {
        int eWeapon = Random.Shared.Next(7);

        if(eWeapon == 1)
        {
            weapon = new Sword();
        }
        else if(eWeapon == 2)
        {
            weapon = new Halberd();
        }
        else if(eWeapon == 3)
        {
            weapon = new Spear();
        }
        else if(eWeapon == 4)
        {
            weapon = new Mace();
        }
        else if(eWeapon == 5)
        {
            weapon = new Shortbow();
        }
        else
        {
            weapon = new Longbow();
        }
    }

    public override void SetName()
    {
        int i = Random.Shared.Next(names.Count);
        name = names[i];
    }

    public bool GetAlive()
    {
        return isAlive;
    }

    public void HealthStatusCheck()
    {
        if(health <= 0)
        {
            isAlive = false;
        }
    }
}
