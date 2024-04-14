public class Character
{
    public string name;

    public int health = 0;

    protected List<string> names = new List<string>() {};

    public Weapon weapon;

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------

    public Character()
    {
        Weapon weapon = new();
    }

    public virtual void SetName()
    {

    }

    public void Attack(Character target, Difficulty difficulty)
    {
        Console.WriteLine($"\n\n{name} attacks with {weapon.weaponName}.");
        int weaponDamage = weapon.Attack();
        if(this is EnemyCharacter)
        {
            weaponDamage = difficulty.ModifyDamage(weaponDamage);
        }
        target.health -= weaponDamage;
        target.health = Math.Max(0, target.health);
        Console.WriteLine($"\n\n{name} dealt {weaponDamage} damage!");
    }

    public void WeaponCriticalAttack(Character target)
    {
        Console.WriteLine($"\n\n{name} attacks with {weapon.weaponName}");
        int weaponDamage = weapon.CriticalAttack();
        target.health -= weaponDamage;
        target.health = Math.Max(0, target.health);
        Console.WriteLine($"\n\n{name} dealt {weaponDamage} damage!");
    }
}
