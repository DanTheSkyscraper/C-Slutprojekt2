public class Difficulty
{
    public string DifficultyName {get; set;}

    private Random Generator = new Random();

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------

    public virtual int ModifyEnemyHealth(int oldHealthValue)
    {
        return oldHealthValue = 100;
    }

    public virtual int ModifyDamage(int oldEnemyDamageValue)
    {
        return oldEnemyDamageValue = Generator.Next(4, 9);
    }

    public virtual int ModifyCriticalDamage(int oldEnemyCriticalDamagevalue)
    {
        return oldEnemyCriticalDamagevalue = Generator.Next(5, 10);
    }
}
