public class Shortbow : RangedWeapon //Shortbow is a type of RangedWeapon (Inheritence). This makes it so that it, for example, has a WeaponName, WeaponDamage, WeaponCriticalDamage and a WeaponAccuracy value.
{
    //This Random Generator makes it so that the parts of the code below that make use of it are randomized.
    private Random Generator = new Random();

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------

    //This code randomizes the amount of damage that the shortbow does, sets a specific value for the critical damage and accuracy of the shortbow, as well as naming the shortbow 'Shortbow' in the WeaponName variable.
    public Shortbow()
    {
        WeaponName = "Shortbow";
        WeaponDamage = Generator.Next(1, 5);
        WeaponCriticalDamage = 4;
        WeaponAccuracy = 7;
    }
}
