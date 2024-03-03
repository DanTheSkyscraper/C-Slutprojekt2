public class Spear : CQCWeapon
{
    private Random Generator = new Random();

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------

    public Spear()
    {
        weaponName = "Spear";
        weaponDamage = Generator.Next(2, 7);
        weaponCriticalDamage = 4;
        weaponBlock = Generator.Next(1, 4);
        weaponAccuracy = 8;
    }
}
