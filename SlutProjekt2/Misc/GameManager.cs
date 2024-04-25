public class GameManager
{
    public PlayerCharacter player;
    public EnemyCharacter enemy;

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------
    public void PrintStats()
    {
        if(player.GetAlive() == true)
        {
            Console.WriteLine($"\nPlayer '{player.Name}' status: Alive");
        }
        else
        {
            Console.WriteLine($"\nPlayer '{player.Name}' status: Dead");
        }
        Console.WriteLine($"\nPlayer '{player.Name}' Health: {player.Health}");
        Console.WriteLine($"Player '{player.Name}' Weapon: {player.Weapon.WeaponName}");

        if(enemy.GetAlive() == true)
        {
            Console.WriteLine($"\nEnemy Player'{enemy.Name}' status: Alive");
        }
        else
        {
            Console.WriteLine($"\nEnemy Player'{enemy.Name}' status: Dead");
        }
        Console.WriteLine($"\nEnemy Player '{enemy.Name}' Health: {enemy.Health}");
        Console.WriteLine($"Enemy Player '{enemy.Name}' Weapon: {enemy.Weapon.WeaponName}");
    }
}
