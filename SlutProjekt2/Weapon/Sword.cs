public class Sword : CQCWeapon //Sword is a type of CQCWeapon (Inheritence). This makes it so that it, for example, has a WeaponName, WeaponDamage, WeaponCriticalDamage and a WeaponAccuracy value.
{
    //This Random Generator makes it so that the parts of the code below that make use of it are randomized.
    private Random Generator = new Random();

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------

    //This code randomizes the amount of damage that the sword does, sets a specific value for the critical damage and accuracy of the sword, as well as naming the sword 'Sword' in the WeaponName variable.
    public Sword()
    {
        WeaponName = "Sword";
        WeaponDamage = Generator.Next(2, 9);
        WeaponCriticalDamage = 3;
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