using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if (speed == 10)
        {
            return 0.77;
        }
        else if (speed == 9)
        {
            return 0.80;
        }
        else if (speed < 9 && speed >= 5)
        {
            return 0.90;
        }
        else if (speed < 5 && speed >= 1)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }

    public static double ProductionRatePerHour(int speed)
    {
        double percetage = SuccessRate(speed);
        return percetage * (speed * 221);
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        int perHour = (int) ProductionRatePerHour(speed);
        return perHour / 60;
    }
}
