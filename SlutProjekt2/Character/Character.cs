public class Character
{
    public string Name {get; set;} //Property

    public int Health {get; set;} = 100;

    protected List<string> names = new List<string>() {"Gerald", "Ruby", "Blake", "Adam", "Theodore", "Lucy", "David", "Marcus"};

    public Weapon Weapon {get; set;}

    public Enchantment Enchantment {get; set;}

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------

    public Character()
    {
        Weapon weapon = new();
    }

    public virtual void SetName()
    {

    }

    public virtual void WeaponAttack(Character target, Difficulty difficulty)
    {
        Console.WriteLine($"\n\n{Name} attacks with {Weapon.WeaponName}.");
        int weaponDamage = Weapon.Attack() + Enchantment.EnchantmentDamage;
        if(this is EnemyCharacter)
        {
            weaponDamage = difficulty.ModifyDamage(weaponDamage);
        }
        target.Health -= weaponDamage;
        target.Health = Math.Max(0, target.Health);
        Console.WriteLine($"\n{Name} dealt {weaponDamage} damage!");
    }

    public void WeaponCriticalAttack(Character target, Difficulty difficulty)
    {
        Console.WriteLine($"\n\n{Name} attacks with {Weapon.WeaponName}");
        int weaponDamage = Weapon.CriticalAttack() + Enchantment.EnchantmentDamage;
        if(this is EnemyCharacter)
        {
            weaponDamage = difficulty.ModifyCriticalDamage(weaponDamage);
        }
        target.Health -= weaponDamage;
        target.Health = Math.Max(0, target.Health);
        Console.WriteLine($"\n{Name} dealt {weaponDamage} damage!");
    }
}
