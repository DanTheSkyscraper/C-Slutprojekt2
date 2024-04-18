public class MediumDifficulty : Difficulty
{
    private Random Generator = new Random();

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------

    public MediumDifficulty()
    {
        DifficultyName = "Medium";
    }

    public override int ModifyEnemyHealth(int oldHealthValue)
    {
        return oldHealthValue = 100;
    }

    public override int ModifyDamage(int oldEnemyDamageValue)
    {
        return oldEnemyDamageValue = Generator.Next(4, 9);
    }

    public override int ModifyCriticalDamage(int oldEnemyCriticalDamagevalue)
    {
        return oldEnemyCriticalDamagevalue = Generator.Next(5, 10);
    }
}
