public class PlayerCharacter : Character //PlayerCharacter is a type of Character (Inheritence). This makes it so that it, for example, has health and a name.
{
    private bool isAlive = true; //This code is later used to determine whether or not the PlayerCharacter is alive or not.

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------

    //This code allows the player to write their name.
    public override void SetName()
    {
        Console.WriteLine("\nWrite your name here:");
        Name = Console.ReadLine();
    }

    //This public bool returns the value of the 'isAlive' variable for the player.
    public bool GetAlive()
    {
        return isAlive;
    }

    //What this code does is check whether or not the health of the player has reached less than or equal to 0. If that is the case, 'isAlive' for the player will be false.
    public void HealthStatusCheck()
    {
        if(Health <= 0)
        {
            isAlive = false;
        }
    }
}
