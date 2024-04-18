public class SharpnessEnchantment : Enchantment
{
    private Random Generator = new Random();

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------

    public SharpnessEnchantment()
    {
        EnchantmentName = "Sharpness Enchantment";
        EnchantmentDamage = Generator.Next(2, 5);
    }
}
