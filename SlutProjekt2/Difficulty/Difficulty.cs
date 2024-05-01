public class Difficulty
{
    //This is a Property. Get; set; indicates that this has a getter and a setter, which means that it both reads and writes the value of the property.
    //This public string with 'DifficultyName' as the variable is used for the names of the three difficulties.
    public string DifficultyName {get; set;}

    //This Random Generator makes it so that the parts of the code below that make use of it are randomized. For this, Random Generator randomizes the normal damage and the critical damage the EnemyCharacter does.
    private Random Generator = new Random();

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------

    //The method 'ModifyEnemyHealth' has the integer paramater 'oldHealthValue', and the value 100 is assigned to it. This value is then returned.
    //This is a virtual int, which means that this can later be overridden in other classes.
    public virtual int ModifyEnemyHealth(int oldHealthValue)
    {
        return oldHealthValue = 100;
    }

    //The method 'ModifyDamage' has the integer paramater 'oldEnemyDamageValue', and it has a Generator randomizing a value between 4-8 assigned to it. This value is then returned.
    //This polymorfism is a virtual int, which means that this can later be overridden in other classes.
    public virtual int ModifyDamage(int oldEnemyDamageValue)
    {
        return oldEnemyDamageValue = Generator.Next(4, 9);
    }

    //The method 'ModifyCritialDamage' has the integer paramater 'oldEnemyCriticalDamageValue', and it has a Generator randomizing a value between 5-9 assigned to it. This value is then returned.
    //This polymorfism is a virtual int, which means that this can later be overridden in other classes.
    public virtual int ModifyCriticalDamage(int oldEnemyCriticalDamageValue)
    {
        return oldEnemyCriticalDamageValue = Generator.Next(5, 10);
    }
}
