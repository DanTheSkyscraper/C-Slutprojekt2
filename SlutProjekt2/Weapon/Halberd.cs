public class Halberd : CQCWeapon //Halberd is a type of CQCWeapon (Inheritence). This makes it so that it, for example, has a WeaponName, WeaponDamage, WeaponCriticalDamage and a WeaponAccuracy value.
{
    //This Random Generator makes it so that the parts of the code below that make use of it are randomized.
    private Random Generator = new Random();

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------

    //This code randomizes the amount of damage that the halberd does, sets a specific value for the critical damage and accuracy of the halberd, as well as naming the halberd 'Halberd' in the WeaponName variable.
    public Halberd()
    {
        WeaponName = "Halberd";
        WeaponDamage = Generator.Next(4, 9);
        WeaponCriticalDamage = 5;
        WeaponAccuracy = 5;
    }

    
}