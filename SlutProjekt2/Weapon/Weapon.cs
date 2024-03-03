public class Weapon
{
    public string weaponName;

    public int weaponDamage;

    public int weaponCriticalDamage;

    public int weaponBlock;

    public int weaponAccuracy;

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------

    public int Attack()
    {
        return Random.Shared.Next(weaponDamage);
    }


    public virtual int CriticalAttack()
    {
        return Random.Shared.Next(weaponDamage);
    }

    public virtual int WeaponBlock()
    {
        return Random.Shared.Next(weaponBlock);
    }
    
}
