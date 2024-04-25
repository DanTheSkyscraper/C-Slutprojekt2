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
            Weapon = new Sword();
        }
        else if(eWeapon == 2)
        {
            Weapon = new Halberd();
        }
        else if(eWeapon == 3)
        {
            Weapon = new Spear();
        }
        else if(eWeapon == 4)
        {
            Weapon = new Mace();
        }
        else if(eWeapon == 5)
        {
            Weapon = new Shortbow();
        }
        else
        {
            Weapon = new Longbow();
        }
    }

    public override void SetName()
    {
        int i = Random.Shared.Next(names.Count);
        Name = names[i];
    }

    public bool GetAlive()
    {
        return isAlive;
    }

    public void HealthStatusCheck()
    {
        if(Health <= 0)
        {
            isAlive = false;
        }
    }

    public override void WeaponAttack(Character target, Difficulty difficulty)
    {   
        if (Random.Shared.Next(2) == 0)
        {
            base.WeaponAttack(target, difficulty);
        }
        else
        {
            base.WeaponCriticalAttack(target, difficulty);
        }
    }
}
