public class Weapon
{
    public string weaponName;

    public int weaponDamage;

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
}
