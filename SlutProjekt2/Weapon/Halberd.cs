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
        WeaponAccuracy = 5;
    }

    
}