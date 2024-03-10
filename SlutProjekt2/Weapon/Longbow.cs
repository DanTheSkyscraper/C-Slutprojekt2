public class Longbow : RangedWeapon
{
    private Random Generator = new Random();

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------

    public Longbow()
    {
        weaponName = "Longbow";
        weaponDamage = Generator.Next(2, 7);
        weaponCriticalDamage = 5;
        weaponBlock = Generator.Next(1, 5);
        weaponAccuracy = 9;
    }
}
