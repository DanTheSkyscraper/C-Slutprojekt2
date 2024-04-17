public class FireEnchantment : Enchantment
{
    private Random Generator = new Random();

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------

    public FireEnchantment()
    {
        enchantmentName = "Fire Enchantment";
        enchantmentDamage = Generator.Next(1, 4);
    }
}
