public class Spear : CQCWeapon
{
    private Random Generator = new Random();

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------

    public Spear()
    {
        WeaponName = "Spear";
        WeaponDamage = Generator.Next(2, 7);
        WeaponCriticalDamage = 4;
        WeaponBlock = Generator.Next(1, 4);
        WeaponAccuracy = 8;
    }
}
