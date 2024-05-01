public class Spear : CQCWeapon //Spear is a type of CQCWeapon (Inheritence). This makes it so that it, for example, has a WeaponName, WeaponDamage, WeaponCriticalDamage and a WeaponAccuracy value.
{
    //This Random Generator makes it so that the parts of the code below that make use of it are randomized.
    private Random Generator = new Random();

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------

    //This code randomizes the amount of damage that the spear does, sets a specific value for the critical damage and accuracy of the spear, as well as naming the spear 'Spear' in the WeaponName variable.
    public Spear()
    {
        WeaponName = "Spear";
        WeaponDamage = Generator.Next(2, 7);
        WeaponCriticalDamage = 4;
        WeaponAccuracy = 8;
    }
}
