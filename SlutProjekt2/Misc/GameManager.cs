public class GameManager //This is a public class, and it allows access through the objects that are created of this class.
{
    public PlayerCharacter player;
    public EnemyCharacter enemy;

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------
    
    //This is a method called 'PrintStats()', and it makes it so that various stats about the player and the enemy are displayed.
    public void PrintStats()
    {
        if(player.GetAlive() == true) //This code makes it so that if the player is still alive, the Console.WriteLine will say 'Alive'.
        {
            Console.WriteLine($"\nPlayer '{player.Name}' status: Alive");
        }
        else //This code makes it so that if the player is dead, the Console.WriteLine will say 'Dead'.
        {
            Console.WriteLine($"\nPlayer '{player.Name}' status: Dead");
        }
        //These Console.WriteLines will show the amount of health and the weapon the player has.
        Console.WriteLine($"\nPlayer '{player.Name}' Health: {player.Health}");
        Console.WriteLine($"Player '{player.Name}' Weapon: {player.Weapon.WeaponName}");

        if(enemy.GetAlive() == true) //This code makes it so that if the enemy is still alive, the Console.WriteLine will say 'Alive'.
        {
            Console.WriteLine($"\nEnemy Player'{enemy.Name}' status: Alive");
        }
        else //This code makes it so that if the enemy is dead, the Console.WriteLine will say 'Dead'.
        {
            Console.WriteLine($"\nEnemy Player'{enemy.Name}' status: Dead");
        }
        //These Console.WriteLines will show the amount of health and the weapon the enemy has.
        Console.WriteLine($"\nEnemy Player '{enemy.Name}' Health: {enemy.Health}");
        Console.WriteLine($"Enemy Player '{enemy.Name}' Weapon: {enemy.Weapon.WeaponName}");
    }
}
