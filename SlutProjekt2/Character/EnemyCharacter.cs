public class EnemyCharacter : Character //EnemyCharacter is a type of Character (Inheritence). This makes it so that it, for example, has health and a name.
{
    private Random Generator = new Random(); //This Random Generator makes it so that the parts of the code below that use it are randomized. For this part, Random Generator randomizes which weapon the enemy has.

    private bool isAlive = true; //This code is later used to determine whether or not the EnemyCharacter is alive or not.

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------

    public void RandomEnemyWeapon() //This code randomizes what weapon the enemy will use, by randomly selecting a number between 1-6.
    {
        int eWeapon = Random.Shared.Next(7);

        if(eWeapon == 1)
        {
            Weapon = new Sword();
        }
        else if(eWeapon == 2)
        {
            Weapon = new Halberd();
        }
        else if(eWeapon == 3)
        {
            Weapon = new Spear();
        }
        else if(eWeapon == 4)
        {
            Weapon = new Mace();
        }
        else if(eWeapon == 5)
        {
            Weapon = new Shortbow();
        }
        else
        {
            Weapon = new Longbow();
        }
    }

    public void RandomEnemyEnchantment() //This code randomizes what enchantment the enemy will use, by randomly selecting a number between 1-4.
    {
        int eEnchantment = Random.Shared.Next(5);

        if(eEnchantment == 1)
        {
            Enchantment = new ElectricityEnchantment();
        }
        else if(eEnchantment == 2)
        {
            Enchantment = new FireEnchantment();
        }
        else if(eEnchantment == 3)
        {
            Enchantment = new ToxicEnchantment();
        }
        else
        {
            Enchantment = new SharpnessEnchantment();
        }
    }

    public override void SetName()
    {
        //In this code, the name of the enemy is randomized by making use of the protected List in 'Character.cs'.
        int i = Random.Shared.Next(names.Count);
        Name = names[i];
    }

    //This public bool returns the value of the 'isAlive' variable for the enemy.
    public bool GetAlive()
    {
        return isAlive;
    }

    //What this code does is check whether or not the health of the enemy has reached less than or equal to 0. If that is the case, 'isAlive' for the enemy will be false.
    public void HealthStatusCheck()
    {
        if(Health <= 0)
        {
            isAlive = false;
        }
    }

    //This code determines what type of attack the enemy will make by randomizing a number as seen below.
    public override void WeaponAttack(Character target, Difficulty difficulty)
    {   
        if (Random.Shared.Next(2) == 0)
        {
            base.WeaponAttack(target, difficulty);
        }
        else
        {
            base.WeaponCriticalAttack(target, difficulty);
        }
    }
}
