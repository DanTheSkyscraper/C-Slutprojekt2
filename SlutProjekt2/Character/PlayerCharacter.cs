public class PlayerCharacter : Character
{
    private bool isAlive = true;

    //----------------------------------------------------------------------
    //----------------------------------------------------------------------

    public override void SetName()
    {
        Console.WriteLine("\nWrite your name here:");
        Name = Console.ReadLine();
    }

    public bool GetAlive()
    {
        return isAlive;
    }

    public void HealthStatusCheck()
    {
        if(Health <= 0)
        {
            isAlive = false;
        }
    }
}
