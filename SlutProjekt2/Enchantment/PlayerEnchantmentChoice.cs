public class PlayerEnchantmentChoice //This is a public class, and it allows access through the objects that are created of this class.
{
    public static Enchantment WeaponEnchantmentChoice()
    {
        string EnchantmentChoice = "";

        while(EnchantmentChoice != "a" && EnchantmentChoice != "b" && EnchantmentChoice != "c" && EnchantmentChoice != "d")
        {
            EnchantmentChoice = Console.ReadLine();

            if(EnchantmentChoice != "a" && EnchantmentChoice != "b" && EnchantmentChoice != "c" && EnchantmentChoice != "d")
            {
                //This Console.WriteLine informs the player that they can only type 'a', 'b', 'c' and 'd', and that their answer should be in lowercase.
                Console.WriteLine("\nPlease type only 'a', 'b', 'c' or 'd'. Your choice should only be written in lowercase.");
            }
        }

        //The code below makes it so that depending on what the player types, they are given a specific enchantment.
        if(EnchantmentChoice == "a")
        {
            Console.WriteLine($"\nYou have chosen to enchant your weapon with the Electricity Enchantment!");
            return new ElectricityEnchantment();
        }
        else if(EnchantmentChoice == "b")
        {
            Console.WriteLine($"\nYou have chosen to enchant your weapon with the Fire Enchantment!");
            return new FireEnchantment();
        }
        else if(EnchantmentChoice == "c")
        {
            Console.WriteLine($"\nYou have chosen to enchant your weapon with the Toxic Enchantment!");
            return new ToxicEnchantment();
        }
        else
        {
            Console.WriteLine($"\nYou have chosen to enchant your weapon with the Sharpness Enchantment!");
            return new SharpnessEnchantment();
        }
    }
}
