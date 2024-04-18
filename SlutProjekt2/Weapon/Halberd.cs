public class Halberd : CQCWeapon
{
    private Random Generator = new Random();

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------

    public Halberd()
    {
        WeaponName = "Halberd";
        WeaponDamage = Generator.Next(4, 9);
        WeaponCriticalDamage = 5;
        WeaponBlock = Generator.Next(1, 4);
        WeaponAccuracy = 5;
    }

    
}