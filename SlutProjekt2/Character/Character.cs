public class Character
{
    //This is a Property. Get; set; indicates that this has a getter and a setter, which means that it both reads and writes the value of the property.
    //This public string Name has the variable 'Name', and it is used for both the player and the enemy.
    public string Name {get; set;}

    //See line 3.
    //This public int has the variable 'Health', and it is used as the health for both the player character and the enemy character.
    public int Health {get; set;} = 100;

    //This is a protected List. Protected works like Private does, but it can be used by classes that inherit it.
    //This means that this can be used by 'EnemyCharacter', where it is used in 'SetName()' to randomize a name for the enemy, as seen below.
    protected List<string> names = new List<string>() {"Gerald", "Ruby", "Blake", "Adam", "Theodore", "Lucy", "David", "Marcus"};

    //See line 3.
    public Weapon Weapon {get; set;}

    //See line 3.
    public Enchantment Enchantment {get; set;}

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------

    public Character() //This is a constructor. This one creates a new instance of 'Weapon' and creates a new variable called 'weapon'.
    {
        Weapon weapon = new();
    }

    //This is a public virtual void. Public means that this can be read and changed from the outside.
    //Virtual means that this baseclass can be overwritten by the subclasses.
    public virtual void SetName()
    {

    }

    //This code is used for the fight between the player and the enemy. This code is for normal attacks.
    public virtual void WeaponAttack(Character target, Difficulty difficulty) //A Parameter is a variable within, in this case, a method which makes it so that values can be passed onto said method. Here, it is 'target' and 'difficulty'.
    {
        Console.WriteLine($"\n\n{Name} attacks with {Weapon.WeaponName}.");
        int weaponDamage = Weapon.Attack();
        if(weaponDamage > 0)
        {
            weaponDamage += Enchantment.EnchantmentDamage;
            if(this is EnemyCharacter) //This code makes it so that if it is the enemy (EnemyCharacter) that is attacking, then it runs the code in the if statement.
            {
                weaponDamage = difficulty.ModifyDamage(weaponDamage); //This code makes it so that the enemy deals different amounts of damage depending on what difficulty it is.
            }
        }
        target.Health -= weaponDamage; //This code subtracts the amount of damage either the player or the enemy receives with their health.
        target.Health = Math.Max(0, target.Health); //'Math.Max'bis a Math class method used to return the larger of two specified numbers. In this code, that would be target.health, which means either the players or the enemies health.
        Console.WriteLine($"\n{Name} dealt {weaponDamage} damage!");
    }

    //This code is used for the fight between the player and the enemy. This code is for critical attacks.
    public void WeaponCriticalAttack(Character target, Difficulty difficulty) //A Parameter is a variable within, in this case, a method which makes it so that values can be passed onto said method. Here, it is 'target' and 'difficulty'.
    {
        Console.WriteLine($"\n\n{Name} does a heavy attack with {Weapon.WeaponName}");
        int weaponDamage = Weapon.CriticalAttack();
        if(weaponDamage > 0)
        {
            weaponDamage += Enchantment.EnchantmentDamage;
            if(this is EnemyCharacter) //This code makes it so that if it is the enemy (EnemyCharacter) that is attacking, then it runs the code in the if statement.
            {
                weaponDamage = difficulty.ModifyCriticalDamage(weaponDamage); //This code makes it so that the enemy deals different amounts of critical damage depending on what difficulty it is.
            }
        }
        target.Health -= weaponDamage; //This code subtracts the amount of damage either the player or the enemy receives with their health.
        target.Health = Math.Max(0, target.Health); //'Math.Max'bis a Math class method used to return the larger of two specified numbers. In this code, that would be target.health, which means either the players or the enemies health.
        Console.WriteLine($"\n{Name} dealt {weaponDamage} damage!");
    }
}
