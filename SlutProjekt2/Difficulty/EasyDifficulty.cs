public class EasyDifficulty : Difficulty //EasyDifficulty is a type of Difficulty (Inheritence). This makes it so that it, for example, has a DifficultyName, modified health value, a modified damage value and a modified critical damage value for the enemy.
{
    //This Random Generator makes it so that the parts of the code below that make use of it are randomized. For this, Random Generator randomizes the normal damage and critical damage the EnemyCharacter does.
    private Random Generator = new Random();

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------

    //This is a constructor. This one sets the value for the variable 'DifficultyName' to the string 'Easy'.
    public EasyDifficulty()
    {
        DifficultyName = "Easy";
    }

    //The method 'ModifyEnemyHealth' has the integer paramater 'oldHealthValue', and the value 100 is assigned to it. This value is subtracted by 10 and then returned.
    //This polymorfism makes it so that 'ModifyEnemyHealth(int oldHealthValue)' is overridden in the 'Difficulty.cs' class.
    public override int ModifyEnemyHealth(int oldHealthValue)
    {
        return oldHealthValue = 100 - 10;
    }

    //The method 'ModifyDamage' has the integer paramater 'oldEnemyDamageValue', and a Generator randomizing a value between 4-8 is assigned to it. This value is subtracted by 2 and then returned.
    //This polymorfism makes it so that 'ModifyDamage(int oldEnemyDamageValue)' is overridden in the 'Difficulty.cs' class.
    public override int ModifyDamage(int oldEnemyDamageValue)
    {
        return oldEnemyDamageValue = Generator.Next(4, 9) - 2;
    }

    //The method 'ModifyCriticalDamage' has the integer paramater 'oldEnemyCriticalDamageValue', and a Generator randomizing a value between 5-9 is assigned to it. This value is subtracted by 2 and then returned.
    //This polymorfism makes it so that 'ModifyCriticalDamage(int oldEnemyCriticalDamageValue)' is overridden in the 'Difficulty.cs' class.
    public override int ModifyCriticalDamage(int oldEnemyCriticalDamagevalue)
    {
        return oldEnemyCriticalDamagevalue = Generator.Next(5, 10) - 2;
    }
}
