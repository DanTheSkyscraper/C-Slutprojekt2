public class Halberd : CQCWeapon
{
    private Random Generator = new Random();

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------

    public Halberd()
    {
        weaponName = "Halberd";
        weaponDamage = Generator.Next(4, 9);
        weaponCriticalDamage = 5;
        weaponBlock = Generator.Next(1, 4);
        weaponAccuracy = 5;
    }

    
}