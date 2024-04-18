public class Sword : CQCWeapon
{
    private Random Generator = new Random();

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------

    public Sword()
    {
        WeaponName = "Sword";
        WeaponDamage = Generator.Next(2, 9);
        WeaponCriticalDamage = 3;
        WeaponBlock = Generator.Next(2, 5);
        WeaponAccuracy = 6;
    }
}















 // private int _damage = 12;
    // public int Damage
    // {
    //     get
    //     {
    //         return _damage;
    //     }
    //     set
    //     {
    //         _damage = value;
    //         if (_damage < 0)
    //         {
    //             _damage = 0;
    //         }
    //     }
    // }