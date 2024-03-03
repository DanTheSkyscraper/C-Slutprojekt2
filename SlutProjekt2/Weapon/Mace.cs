public class Mace : CQCWeapon
{
    private Random Generator = new Random();

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------

    public Mace()
    {
        weaponName = "Mace";
        weaponDamage = Generator.Next(4, 10);
        weaponCriticalDamage = 6;
        weaponBlock = Generator.Next(2, 4);
        weaponAccuracy = 4;
    }
}
