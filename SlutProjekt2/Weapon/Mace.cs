public class Mace : CQCWeapon //Mace is a type of CQCWeapon (Inheritence). This makes it so that it, for example, has a WeaponName, WeaponDamage, WeaponCriticalDamage and a WeaponAccuracy value.
{
    //This Random Generator makes it so that the parts of the code below that make use of it are randomized.
    private Random Generator = new Random();

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------

    //This code randomizes the amount of damage that the mace does, sets a specific value for the critical damage and accuracy of the mace, as well as naming the mace 'Mace' in the WeaponName variable.
    public Mace()
    {
        WeaponName = "Mace";
        WeaponDamage = Generator.Next(4, 10);
        WeaponCriticalDamage = 6;
        WeaponAccuracy = 4;
    }
}
