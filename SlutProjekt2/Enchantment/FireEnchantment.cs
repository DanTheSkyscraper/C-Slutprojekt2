public class FireEnchantment : Enchantment
{
    private Random Generator = new Random();

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------

    public FireEnchantment()
    {
        EnchantmentName = "Fire Enchantment";
        EnchantmentDamage = Generator.Next(1, 4);
    }
}
