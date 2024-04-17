﻿public class ElectricityEnchantment : Enchantment
{
    private Random Generator = new Random();

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------

    public ElectricityEnchantment()
    {
        enchantmentName = "Electricity Enchantment";
        enchantmentDamage = Generator.Next(2, 3);
    }
}
