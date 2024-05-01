public class Longbow : RangedWeapon //Longbow is a type of RangedWeapon (Inheritence). This makes it so that it, for example, has a WeaponName, WeaponDamage, WeaponCriticalDamage and a WeaponAccuracy value.
{
    //This Random Generator makes it so that the parts of the code below that make use of it are randomized.
    private Random Generator = new Random();

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------

    //This code randomizes the amount of damage that the longbow does, sets a specific value for the critical damage and accuracy of the longbow, as well as naming the longbow 'Longbow' in the WeaponName variable.
    public Longbow()
    {
        WeaponName = "Longbow";
        WeaponDamage = Generator.Next(2, 7);
        WeaponCriticalDamage = 5;
        WeaponAccuracy = 9;
    }
}
