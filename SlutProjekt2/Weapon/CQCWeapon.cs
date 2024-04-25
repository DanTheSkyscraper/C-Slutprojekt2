public class CQCWeapon : Weapon
{
    private Random Generator = new Random();

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------
    public override int Attack()
    {

        if(Random.Shared.Next(1, 10) <= WeaponAccuracy)
        {
            Console.WriteLine("\n\nHit!");
            return Random.Shared.Next(WeaponDamage);
        }
        else
        {
            Console.WriteLine("\n\nMiss!");
            return 0;
        }

    }

    public override int CriticalAttack()
    {
        if(Random.Shared.Next(1, 10) <= WeaponAccuracy)
        {
            Console.WriteLine("\n\nHit!");
            return WeaponCriticalDamage + Random.Shared.Next(WeaponDamage);
        }
        else
        {
            Console.WriteLine("\n\nMiss!");
            return 0;
        }
    }

}
