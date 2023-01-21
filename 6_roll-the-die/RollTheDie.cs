using System;

public class Player
{
    Random rnd = new Random();

    public int RollDie()
    {
        return rnd.Next(17) + 1;
    }

    public double GenerateSpellStrength()
    {
        return rnd.NextDouble();
    }
}
