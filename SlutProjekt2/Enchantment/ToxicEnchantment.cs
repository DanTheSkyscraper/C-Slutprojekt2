public class ToxicEnchantment : Enchantment
{
    private Random Generator = new Random();

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------

    public ToxicEnchantment()
    {
        EnchantmentName = "Toxic Enchantment";
        EnchantmentDamage = Generator.Next(1, 3);
    }
}
