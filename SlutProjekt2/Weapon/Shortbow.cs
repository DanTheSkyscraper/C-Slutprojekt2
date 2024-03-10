public class Shortbow : RangedWeapon
{
    private Random Generator = new Random();

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------

    public Shortbow()
    {
        weaponName = "Shortbow";
        weaponDamage = Generator.Next(1, 5);
        weaponCriticalDamage = 4;
        weaponBlock = Generator.Next(1, 3);
        weaponAccuracy = 7;
    }
}
