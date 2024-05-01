public class CQCWeapon : Weapon //CQCWeapon is a type of Weapon (Inheritence).
{
    //This Random Generator makes it so that the parts of the code below that make use of it are randomized.
    private Random Generator = new Random();

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------

    //This code is used to determine if the normal attack of the weapon that the player and the enemy uses hits or misses. This makes use of the WeaponAccuracy variable.
    public override int Attack()
    {

        if(Random.Shared.Next(1, 10) <= WeaponAccuracy)
        {
            Console.WriteLine("\n\nHit!");
            int weaponDamage = Random.Shared.Next(WeaponDamage);
            weaponDamage += Enchantment.EnchantmentDamage;
            return weaponDamage;
        }
        else
        {
            Console.WriteLine("\n\nMiss!");
            return 0;
        }

    }

    //This code is used to determine if the critical attack of the weapon that the player and the enemy uses hits or misses. This makes use of the WeaponAccuracy variable.
    public override int CriticalAttack()
    {
        if(Random.Shared.Next(1, 10) <= WeaponAccuracy)
        {
            Console.WriteLine("\n\nHit!");
            int weaponDamage = WeaponCriticalDamage + Random.Shared.Next(WeaponDamage);
            weaponDamage += Enchantment.EnchantmentDamage;
            return weaponDamage;
        }
        else
        {
            Console.WriteLine("\n\nMiss!");
            return 0;
        }
    }

}
