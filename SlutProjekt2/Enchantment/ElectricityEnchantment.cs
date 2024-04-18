public class ElectricityEnchantment : Enchantment
{
    private Random Generator = new Random();

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------

    public ElectricityEnchantment()
    {
        EnchantmentName = "Electricity Enchantment";
        EnchantmentDamage = Generator.Next(2, 3);
    }
}
