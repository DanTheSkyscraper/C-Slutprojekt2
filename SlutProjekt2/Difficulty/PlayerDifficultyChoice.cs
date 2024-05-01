public class PlayerDifficultyChoice //This is a public class, and it allows access through the objects that are created of this class.
{
    public static Difficulty DifficultyChoice()
    {
        string difficultyChoice = "";

        while(difficultyChoice != "easy" && difficultyChoice != "medium" && difficultyChoice != "hard")
        {
            difficultyChoice = Console.ReadLine();

            if(difficultyChoice != "easy" && difficultyChoice != "medium" && difficultyChoice != "hard")
            {
                //This Console.WriteLine informs the player that they can only write 'easy', 'medium' and 'hard', and that their answer should be in lowercase.
                Console.WriteLine("\nPlease write only 'easy', 'medium' or 'hard'. You should only write in lowercase.");
            }
        }

        //The code below makes it so that depending on what the player writes, they are choosing a specific difficulty.
        if(difficultyChoice == "easy")
        {
            return new EasyDifficulty();
        }
        else if(difficultyChoice == "medium")
        {
            return new MediumDifficulty();
        }
        else
        {
            return new HardDifficulty();
        }
    }
}
