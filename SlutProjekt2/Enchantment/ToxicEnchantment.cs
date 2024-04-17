public class ToxicEnchantment : Enchantment
{
    private Random Generator = new Random();

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------

    public ToxicEnchantment()
    {
        enchantmentName = "Toxic Enchantment";
        enchantmentDamage = Generator.Next(1, 3);
    }
}
