string restartGame = "y";
while(restartGame == "y")
{
    Console.WriteLine("Welcome player! We were waiting for you. Your opponent is ready, so go ahead and prepare yourself.");

    GameManager manager = new();
    PlayerCharacter player = new();
    EnemyCharacter enemy = new();

    manager.player = player;
    manager.enemy = enemy;

    player.SetName();

    Console.WriteLine("\nIs that your name? Very well. Let us continue...");
    
    Console.WriteLine("\nThe one you will be facing is:");
    enemy.SetName();
    Console.WriteLine(enemy.Name);

    Console.WriteLine("\nFirst, both opponents will select their weapons. You may choose from either melee weapons or ranged weapons.");
    Console.WriteLine("\nFirst of all, what type of weapon will you choose?");
    Console.WriteLine("\nYou have 2 choices. CQC weapons or Ranged weapons? ['a' = CQC // 'b' = Ranged]. Please answer in lowercase.");

    player.Weapon = PlayerWeaponChoice.WeaponTypeChoice();

    Console.WriteLine("\nNow, what enchantment will you choose for your weapon? As per local game rules, this is unfortunately required");
    Console.WriteLine("\nYou have 4 choices. ['a' = Electricity // 'b' = Fire // 'c' = Toxic // 'd' = Sharpness]");

    player.Enchantment = PlayerEnchantmentChoice.WeaponEnchantmentChoice();

    enemy.RandomEnemyWeapon();

    Console.WriteLine("\nNow that both have what they need, it is time to determine the difficulty. What is it?");
    Console.WriteLine("\nYou have 3 choices. Easy, Medium or Hard. ['easy' = Easy // 'medium' = Medium // 'hard' = Hard]");

    Difficulty diff = PlayerDifficultyChoice.DifficultyChoice();
    enemy.Health = diff.ModifyEnemyHealth(enemy.Health);

    Console.WriteLine($"\n{diff.DifficultyName} is now the chosen difficulty. Let us begin.");
    while(player.Health > 0 && enemy.Health > 0)
    {
        Console.WriteLine("\n\n-----------------------------------");
        manager.PrintStats();

        Console.WriteLine("\nFight!");
        Console.WriteLine("\n\nChoose how to attack! ['a' = Normal Attack // 'b' = Charge Attack]");

        string BattleAlternatives = PlayerBattleChoice.BattleChoice();

        if(BattleAlternatives == "a")
        {
            player.WeaponAttack(enemy, diff);
            enemy.WeaponAttack(player, diff);

            player.HealthStatusCheck();
            enemy.HealthStatusCheck();
        }
        else
        {
            player.WeaponCriticalAttack(enemy, diff);
            enemy.WeaponAttack(player, diff);

            player.HealthStatusCheck();
            enemy.HealthStatusCheck();
        }
    }
    Console.WriteLine("\n\n----------------------------------");
    Console.WriteLine("\nThe fight is over.");

    if(player.GetAlive() == true && enemy.GetAlive() == false)
    {
        Console.WriteLine($"\n'{player.Name}' has won the game. Congratulations!");
    }
    else if(player.GetAlive() == false && enemy.GetAlive() == true)
    {
        Console.WriteLine($"\n'{enemy.Name}' has won the game. Congratulations!");
    }
    else
    {
        Console.WriteLine($"\nBoth '{player.Name}' and {enemy.Name} have fallen. It is a draw!");
    }


    Console.WriteLine("\nThe game is over. Do you want to play again? [y/n]");
    restartGame = Console.ReadLine();
}
Console.ReadLine();
