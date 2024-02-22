public class PlayerFightChoice //This is a public class, and it allows access through the objects that are created of this class.
{
    public static string BattleChoice()
    {
        string battleAlt = "";
        while(battleAlt != "a" && battleAlt != "b" && battleAlt != "c")
        {
            battleAlt = Console.ReadLine();

            if(battleAlt != "a" && battleAlt != "b" && battleAlt != "c")
            {
                //This Console.WriteLine will inform the player that they can only choose to type the following: 'a', 'b' or 'c'.
                Console.WriteLine("\n\nPlease type only 'a', 'b' or 'c'.");
            }
        }
        return battleAlt;
    }
}
