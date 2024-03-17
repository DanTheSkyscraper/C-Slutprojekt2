public class PlayerWeaponChoice //This is a public class, and it allows access through the objects that are created of this class.
{
    public static Weapon CQCWeaponChoice()
    {
        string weaponCQCChoice = "";

        while(weaponCQCChoice != "a" && weaponCQCChoice != "b" && weaponCQCChoice != "c" && weaponCQCChoice != "d")
        {
            weaponCQCChoice = Console.ReadLine();

            if(weaponCQCChoice != "a" && weaponCQCChoice != "b" && weaponCQCChoice != "c" && weaponCQCChoice != "d")
            {
                //This Console.WriteLine informs the player that they can only type 'a', 'b', 'c' and 'd', and that their answer should be in lowercase.
                Console.WriteLine("\n\nPlease type only 'a', 'b', 'c' or 'd'. Your choice should only be written in lowercase");
            }
        }

        //The code below makes it so that depending on what letter the player types, they are given the CQC weapon that letter belongs to.
        if(weaponCQCChoice == "a")
        {
            Console.WriteLine("\n\nYou have chosen the Sword.");
            return new Sword();
        }
        else if(weaponCQCChoice == "b")
        {
            Console.WriteLine("\n\nYou have chosen the Mace.");
            return new Mace();
        }
        else if(weaponCQCChoice == "c")
        {
            Console.WriteLine("\n\nYou have chosen the Spear.");
            return new Spear();
        }
        else
        {
            Console.WriteLine("\n\nYou have chosen the Axe.");
            return new Halberd();
        }
    }


    public static Weapon RangedWeaponChoice()
    {
        string weaponRangedChoice = "";

        while(weaponRangedChoice != "a" && weaponRangedChoice != "b")
        {
            weaponRangedChoice = Console.ReadLine();

            if(weaponRangedChoice != "a" && weaponRangedChoice != "b")
            {
                //This Console.WriteLine informs the player that they can only type 'a' and 'b', and that their answer should be in lowercase.
                Console.WriteLine("\n\nPlease type only 'a' and 'b'. Your choice should only be written in lowercase");
            }
        }

        //The code below makes it so that depending on what letter the player types, they are given the ranged weapon that letter belongs to.
        if(weaponRangedChoice == "a")
        {
            Console.WriteLine("\n\nYou have chosen the Longbow.");
            return new Longbow();
        }
        else
        {
            Console.WriteLine("\n\nYou have chosen the Shortbow.");
            return new Shortbow();
        }
    }
}
