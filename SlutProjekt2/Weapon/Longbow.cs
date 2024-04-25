public class Longbow : RangedWeapon
{
    private Random Generator = new Random();

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------

    public Longbow()
    {
        WeaponName = "Longbow";
        WeaponDamage = Generator.Next(2, 7);
        WeaponCriticalDamage = 5;
        WeaponAccuracy = 9;
    }
}
