﻿public class HardDifficulty : Difficulty
{
    private Random Generator = new Random();

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------

    public HardDifficulty()
    {
        DifficultyName = "Hard";
    }

    public override int ModifyEnemyHealth(int oldHealthValue)
    {
        return oldHealthValue = 100 + 10;
    }

    public override int ModifyDamage(int oldEnemyDamageValue)
    {
        return oldEnemyDamageValue = Generator.Next(4, 9) + 2;
    }

    public override int ModifyCriticalDamage(int oldEnemyCriticalDamagevalue)
    {
        return oldEnemyCriticalDamagevalue = Generator.Next(5, 10) + 2;
    }
}
