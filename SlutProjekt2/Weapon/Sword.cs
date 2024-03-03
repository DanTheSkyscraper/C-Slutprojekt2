public class Sword : CQCWeapon
{
    private Random Generator = new Random();

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------

    public Sword()
    {
        weaponName = "Sword";
        weaponDamage = Generator.Next(2, 9);
        weaponCriticalDamage = 3;
        weaponBlock = Generator.Next(2, 5);
        weaponAccuracy = 6;
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