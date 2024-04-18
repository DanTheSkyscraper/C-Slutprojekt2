public class Shortbow : RangedWeapon
{
    private Random Generator = new Random();

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------

    public Shortbow()
    {
        WeaponName = "Shortbow";
        WeaponDamage = Generator.Next(1, 5);
        WeaponCriticalDamage = 4;
        WeaponBlock = Generator.Next(1, 3);
        WeaponAccuracy = 7;
    }
}
