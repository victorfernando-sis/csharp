class Lasagna
{
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    public int RemainingMinutesInOven(int inOvenTime)
    {
        return ExpectedMinutesInOven() - inOvenTime;
    }

    public int PreparationTimeInMinutes(int layers)
    {
        return 2 * layers;
    }

    public int ElapsedTimeInMinutes(int layers, int inOvenTime)
    {
        return PreparationTimeInMinutes(layers) + inOvenTime;
    }
}
