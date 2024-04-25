public class Mace : CQCWeapon
{
    private Random Generator = new Random();

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------

    public Mace()
    {
        WeaponName = "Mace";
        WeaponDamage = Generator.Next(4, 10);
        WeaponCriticalDamage = 6;
        WeaponAccuracy = 4;
    }
}
