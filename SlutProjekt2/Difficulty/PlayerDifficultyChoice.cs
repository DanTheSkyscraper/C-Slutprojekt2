public class PlayerDifficultyChoice
{
    public static Difficulty DifficultyChoice()
    {
        string difficultyChoice = "";

        while(difficultyChoice != "easy" && difficultyChoice != "medium" && difficultyChoice != "hard")
        {
            difficultyChoice = Console.ReadLine();

            if(difficultyChoice != "easy" && difficultyChoice != "medium" && difficultyChoice != "hard")
            {
                Console.WriteLine("\nPlease write only 'easy', 'medium' or 'hard'. You should only write in lowercase.");
            }
        }

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
