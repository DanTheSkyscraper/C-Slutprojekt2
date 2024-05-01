public class PlayerBattleChoice //This is a public class, and it allows access through the objects that are created of this class.
{
    public static string BattleChoice()
    {
        string battleAlt = "";
        while(battleAlt != "a" && battleAlt != "b")
        {
            battleAlt = Console.ReadLine();

            if(battleAlt != "a" && battleAlt != "b")
            {
                //This Console.WriteLine will inform the player that they can only choose to type the following: 'a' or 'b'.
                Console.WriteLine("\nPlease type only 'a' or 'b'. Your choice should only be written in lowercase.");
            }
        }
        return battleAlt;
    }
}
