public class RangedWeapon : Weapon
{
    private Random Generator = new Random();

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------

    public override int CriticalAttack()
    {
        Console.WriteLine("\n\nYou aim for a weakspot!");
        if(Random.Shared.Next(1, 10) <= weaponAccuracy)
        {
            return weaponCriticalDamage + Random.Shared.Next(weaponDamage);
        }
        else
        {
            Console.WriteLine("\n\nYou missed your opponent!");
            return 0;
        }
    }

    public override int WeaponBlock()
    {
        Console.WriteLine("\n\nYou blocked with your weapon.");
        return Random.Shared.Next(weaponDamage) - Random.Shared.Next(weaponBlock);
    }

    public int weaponAccuracyCheck()
    {
        if(Random.Shared.Next(1, 10) <= weaponAccuracy)
        {
            Console.WriteLine("\n\nYou hit your opponent!");
            return Random.Shared.Next(weaponDamage);
        }
        else
        {
            Console.WriteLine("\n\nYou missed your opponent!");
            return 0;
        }
    }
}
