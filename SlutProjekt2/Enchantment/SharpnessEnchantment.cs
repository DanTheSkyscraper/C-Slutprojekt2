public class SharpnessEnchantment : Enchantment
{
    private Random Generator = new Random();

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------

    public SharpnessEnchantment()
    {
        enchantmentName = "Sharpness Enchantment";
        enchantmentDamage = Generator.Next(2, 5);
    }
}
