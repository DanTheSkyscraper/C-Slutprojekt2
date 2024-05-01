//The start of the game is here.
string restartGame = "y";
while(restartGame == "y") //This is a while loop. This one will make it so that the player can restart the game by pressing 'y'.
{
    Console.WriteLine("Welcome player! We were waiting for you. Your opponent is ready, so go ahead and prepare yourself.");

    //The following three lines of code (line 10, 11, 12) create instances of their respective classes with assigned variables.
    //This makes it so that variables are created for the GameManager, PlayerCharacter and EnemyCharacter, which is later used for the rest of the code.

    GameManager manager = new(); //This instance of the class 'GameManager' is assigned the 'manager' variable.
    PlayerCharacter player = new(); //This instance of the class 'PlayerCharacter' is assigned the 'player' variable.
    EnemyCharacter enemy = new(); //This instance of the class 'EnemyCharacter' is assigned the 'enemy' variable.

    manager.player = player; //This ensures that 'player' in 'Program.cs' and 'player' in 'GameManager.cs' are the same variable.
    manager.enemy = enemy; //This ensures that 'enemy' in 'Program.cs' and 'enemy' in 'GameManager.cs' are the same variable.

    player.SetName(); //This is a method call for the 'SetName()' method on 'player'. See 'PlayerCharacter.cs'.

    Console.WriteLine("\nIs that your name? Very well. Let us continue...");
    
    Console.WriteLine("\nThe one you will be facing is:");
    enemy.SetName(); //This is a method call for the 'SetName()' method on 'enemy'. See 'EnemyCharacter.cs'.
    Console.WriteLine(enemy.Name);

    Console.WriteLine("\nFirst, both opponents will select their weapons. You may choose from either melee weapons or ranged weapons.");
    Console.WriteLine("\nFirst of all, what type of weapon will you choose?");
    Console.WriteLine("\nYou have 2 choices. CQC weapons or Ranged weapons? ['a' = CQC // 'b' = Ranged]. Please answer in lowercase.");

    //This code makes it so that the player can choose what type of weapon they want to use, and it also ensures they can not type anything else but the 2 options shown above.
    player.Weapon = PlayerWeaponChoice.WeaponTypeChoice();

    Console.WriteLine("\nNow, what enchantment will you choose for your weapon? As per local game rules, this is unfortunately required");
    Console.WriteLine("\nYou have 4 choices. ['a' = Electricity // 'b' = Fire // 'c' = Toxic // 'd' = Sharpness]");

    //This code makes it so that the player can choose an enchantment, and it also ensures they can not type anything else but the 4 options shown above.
    player.Enchantment = PlayerEnchantmentChoice.WeaponEnchantmentChoice();

    //This code makes it so that the enemy gets a random weapon and enchantment.
    enemy.RandomEnemyWeapon();
    enemy.RandomEnemyEnchantment();

    Console.WriteLine("\nNow that both of you have what you need, it is time to determine the difficulty. What is it?");
    Console.WriteLine("\nYou have 3 choices. Easy, Medium or Hard. ['easy' = Easy // 'medium' = Medium // 'hard' = Hard]");

    //This code makes it so that the player can choose what difficulty they want to play on. The result of that choice is then assigned to 'diff'.
    Difficulty diff = PlayerDifficultyChoice.DifficultyChoice();
    enemy.Health = diff.ModifyEnemyHealth(enemy.Health); //Depending on the difficulty the player chooses, the health of the enemy is changed to what it should be on that difficulty.

    Console.WriteLine($"\n{diff.DifficultyName} is now the chosen difficulty. Let us begin.");
    while(player.Health > 0 && enemy.Health > 0) //This while loop will run as long as neither the player or the enemy has reached 0 health. If either of them reach 0 health, the game is over.
    {
        Console.WriteLine("\n\n-----------------------------------");
        manager.PrintStats(); //'manager.PrintStats();' makes it so that the status of the player and the enemy, their health and their weapons are displayed each round.

        Console.WriteLine("\nFight!");
        Console.WriteLine("\n\nChoose how to attack! ['a' = Normal Attack // 'b' = Charge Attack]");

        //This code is a method that allows the player to choose which type of attack they want to make.
        string BattleAlternatives = PlayerBattleChoice.BattleChoice();

        if(BattleAlternatives == "a") //If the player chooses alternative 'a', this runs.
        {
            //This code makes it so that the player and the enemy attack each other with a normal attack.
            player.WeaponAttack(enemy, diff);
            enemy.WeaponAttack(player, diff);

            player.HealthStatusCheck();
            enemy.HealthStatusCheck();
        }
        else //If the player chooses alternative 'b', this runs.
        {
            //This code makes it so that the player and the enemy attack each other with a critical attack.
            player.WeaponCriticalAttack(enemy, diff);
            enemy.WeaponAttack(player, diff);

            player.HealthStatusCheck();
            enemy.HealthStatusCheck();
        }
    }
    Console.WriteLine("\n\n----------------------------------"); //When the health of either the player or the enemy, or both of them, reaches 0, the code below starts.
    Console.WriteLine("\nThe fight is over.");

    if(player.GetAlive() == true && enemy.GetAlive() == false) //This if statement makes it so that if the enemy reaches 0 health, the player wins.
    {
        Console.WriteLine($"\n'{player.Name}' has won the game. Congratulations!");
    }
    else if(player.GetAlive() == false && enemy.GetAlive() == true) //This if statement makes it so that if the player reaches 0 health, the enemy wins.
    {
        Console.WriteLine($"\n'{enemy.Name}' has won the game. Congratulations!");
    }
    else //This code makes it so that if both the player and the enemy reach 0 health, it is a draw.
    {
        Console.WriteLine($"\nBoth '{player.Name}' and {enemy.Name} have fallen. It is a draw!");
    }

    //The while loop ends here. If the player types 'y', the game restarts. If not, the game closes.
    Console.WriteLine("\nThe game is over. Do you want to play again? [y/n]");
    restartGame = Console.ReadLine();
}
Console.ReadLine();
