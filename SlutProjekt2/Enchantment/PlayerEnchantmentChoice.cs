public class PlayerEnchantmentChoice
{
    public static Enchantment WeaponEnchantmentChoice()
    {
        string EnchantmentChoice = "";

        while(EnchantmentChoice != "a" && EnchantmentChoice != "b" && EnchantmentChoice != "c" && EnchantmentChoice != "d" && EnchantmentChoice != "e")
        {
            EnchantmentChoice = Console.ReadLine();

            if(EnchantmentChoice != "a" && EnchantmentChoice != "b" && EnchantmentChoice != "c" && EnchantmentChoice != "d" && EnchantmentChoice != "e")
            {
                Console.WriteLine("\n\nPlease type only 'a', 'b', 'c', 'd' or 'e'. Your choice should only be written in lowercase");
            }
        }

        if(EnchantmentChoice == "a")
        {
            Console.WriteLine($"\n\nYou have chosen to enchant your weapon with the Electricity Enchantment!");
            return new ElectricityEnchantment();
        }
        else if(EnchantmentChoice == "b")
        {
            Console.WriteLine($"\n\nYou have chosen to enchant your weapon with the Fire Enchantment!");
            return new FireEnchantment();
        }
        else if(EnchantmentChoice == "c")
        {
            Console.WriteLine($"\n\nYou have chosen to enchant your weapon with the Toxic Enchantment!");
            return new ToxicEnchantment();
        }
        else
        {
            Console.WriteLine($"\n\nYou have chosen to enchant your weapon with the Sharpness Enchantment!");
            return new SharpnessEnchantment();
        }
    }
}
