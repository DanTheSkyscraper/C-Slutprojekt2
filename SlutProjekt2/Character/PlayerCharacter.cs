public class PlayerCharacter : Character
{
    private bool isAlive = true;

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------

    public override void SetName()
    {
        Console.WriteLine("\n\nWrite your name here:");
        name = Console.ReadLine();
    }

    public bool GetAlive()
    {
        return isAlive;
    }

    public void HealthStatusCheck()
    {
        if(health <= 0)
        {
            isAlive = false;
        }
    }
}
