public class RangedWeapon : Weapon
{
    private Random Generator = new Random();

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------

    public override int CriticalAttack()
    {
        Console.WriteLine("\n\nYou aim for a weakspot!");
        if(Random.Shared.Next(1, 10) <= WeaponAccuracy)
        {
            return WeaponCriticalDamage + Random.Shared.Next(WeaponDamage);
        }
        else
        {
            Console.WriteLine("\n\nYou missed your opponent!");
            return 0;
        }
    }

    public override int WeaponBlocked()
    {
        Console.WriteLine("\n\nYou blocked with your weapon.");
        return Random.Shared.Next(WeaponDamage) - Random.Shared.Next(WeaponBlock);
    }

    public int weaponAccuracyCheck()
    {
        if(Random.Shared.Next(1, 10) <= WeaponAccuracy)
        {
            Console.WriteLine("\n\nYou hit your opponent!");
            return Random.Shared.Next(WeaponDamage);
        }
        else
        {
            Console.WriteLine("\n\nYou missed your opponent!");
            return 0;
        }
    }
}
