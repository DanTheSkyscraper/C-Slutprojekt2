public class Weapon
{
    public string WeaponName {get; set;}

    public int WeaponDamage {get; set;}

    public int WeaponCriticalDamage {get; set;}

    public int WeaponBlock {get; set;}

    public int WeaponAccuracy {get; set;}

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------

    public int Attack()
    {
        return Random.Shared.Next(WeaponDamage);
    }
    

    public virtual int CriticalAttack()
    {
        return Random.Shared.Next(WeaponDamage);
    }

    public virtual int WeaponBlocked()
    {
        return Random.Shared.Next(WeaponBlock);
    }
    
}
