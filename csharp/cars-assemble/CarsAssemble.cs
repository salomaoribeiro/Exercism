using System;

static class AssemblyLine
{
    private const int PRODUCT_PER_HOUR = 221;
    private const int MINUTES_IN_HOUR = 60;

    public static double SuccessRate(int speed)
    {
        if (speed == 0) return 0;
        else if (speed <= 4) return 1;
        else if (speed <= 8) return 0.9;
        else if (speed == 9) return 0.8;
        else return 0.77;
    }

    public static double ProductionRatePerHour(int speed)
    {
        return speed * PRODUCT_PER_HOUR * SuccessRate(speed);
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return (int)(ProductionRatePerHour(speed) / 60);
    }
}
