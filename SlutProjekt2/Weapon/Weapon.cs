public class Weapon //This is a public class, and it allows access through the objects that are created of this class.
{
    //For all of these, see line 3 in Character.cs.

    //This public string with 'WeaponName' as the variable is used for the names of the various weapons.
    public string WeaponName {get; set;}

    //This public int with 'WeaponDamage' as the variable is used for the damage of the weapons.
    public int WeaponDamage {get; set;}

    //This public int with 'WeaponCriticalDamage' as the variable is used for the critical damage of the weapons.
    public int WeaponCriticalDamage {get; set;}

    //This public int with 'WeaponAccuracy' as the variable is used for the accuracy of the weapons.
    public int WeaponAccuracy {get; set;}

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------

    //This code is a method named 'Attack', and it is used to generate a random int value for the variable 'WeaponDamage'. This is then returned.
    //This is a virtual int, which means that this can later be overridden in other classes.
    public virtual int Attack()
    {
        return Random.Shared.Next(WeaponDamage);
    }

    //This code is a method named 'CriticalAttack', and it is used to generate a random int value for the variable 'WeaponCriticalDamage'. This is then returned.
    //This is a virtual int, which means that this can later be overridden in other classes.
    public virtual int CriticalAttack()
    {
        return Random.Shared.Next(WeaponDamage);
    }
}
