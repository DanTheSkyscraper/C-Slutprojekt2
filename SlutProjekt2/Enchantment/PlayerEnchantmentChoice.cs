public class PlayerEnchantmentChoice
{
    public static Enchantment WeaponEnchantmentChoice()
    {
        string EnchantmentChoice = "";

        while(EnchantmentChoice != "a" && EnchantmentChoice != "b" && EnchantmentChoice != "c" && EnchantmentChoice != "d")
        {
            EnchantmentChoice = Console.ReadLine();

            if(EnchantmentChoice != "a" && EnchantmentChoice != "b" && EnchantmentChoice != "c" && EnchantmentChoice != "d")
            {
                Console.WriteLine("\nPlease type only 'a', 'b', 'c' or 'd'. Your choice should only be written in lowercase.");
            }
        }

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
