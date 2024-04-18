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
            Console.WriteLine($"\n\nPlayer '{player.Name}' status: Alive");
        }
        else
        {
            Console.WriteLine($"\n\nPlayer '{player.Name}' status: Dead");
        }
        Console.WriteLine($"\nPlayer '{player.Name}' Health: {player.Health}");
        Console.WriteLine($"Player '{player.Name}' Weapon: {player.Weapon.WeaponName}");

        if(enemy.GetAlive() == true)
        {
            Console.WriteLine($"\n\nEnemy '{enemy.Name}' status: Alive");
        }
        else
        {
            Console.WriteLine($"\n\nEnemy '{enemy.Name}' status: Dead");
        }
        Console.WriteLine($"\nPlayer '{enemy.Name}' Health: {enemy.Health}");
        Console.WriteLine($"Player '{enemy.Name}' Weapon: {enemy.Weapon.WeaponName}");
    }
}
