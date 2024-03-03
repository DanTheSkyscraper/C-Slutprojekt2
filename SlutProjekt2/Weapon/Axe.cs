public class Axe : CQCWeapon
{
    private Random Generator = new Random();

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------

    public Axe()
    {
        weaponName = "Axe";
        weaponDamage = Generator.Next(4, 9);
        weaponCriticalDamage = 5;
        weaponBlock = Generator.Next(1, 4);
        weaponAccuracy = 5;
    }
}