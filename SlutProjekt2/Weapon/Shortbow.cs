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
        WeaponAccuracy = 7;
    }
}
