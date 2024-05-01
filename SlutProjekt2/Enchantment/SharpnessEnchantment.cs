public class SharpnessEnchantment : Enchantment //SharpnessEnchantment is a type of Enchantment (Inheritence). This makes it so that it, for example, has an EnchantmentName and EnchantmentDamage.
{
    //This Random Generator makes it so that the parts of the code below that make use of it are randomized. For this, Random Generator randomizes the damage the enchantment does.
    private Random Generator = new Random();

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------

    //This code randomizes the amount of damage that the enchantment does, as well as naming the enchantment 'Sharpness Enchantment' in the EnchantmentName variable.
    public SharpnessEnchantment()
    {
        EnchantmentName = "Sharpness Enchantment";
        EnchantmentDamage = Generator.Next(2, 5);
    }
}
