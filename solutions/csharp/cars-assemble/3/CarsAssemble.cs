static class AssemblyLine
{
    const int baseRate = 221;
    public static double SuccessRate(int speed)
    {
        if (speed == 0)
        {
            return (double)speed;
        }

        if (speed >= 1 && speed <= 4)
        {
            return (double)1.00;
        }

        if (speed >= 5 && speed <= 8)
        {
            return (double)0.90;
        }

        if (speed == 9)
        {
            return (double)0.80;
        }

        if (speed == 10)
        {
            return (double)0.77;
        }

        throw new NotImplementedException("Please implement the (static) AssemblyLine.SuccessRate() method");
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        return speed * baseRate;
        
        throw new NotImplementedException("Please implement the (static) AssemblyLine.ProductionRatePerHour() method");
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        double successPerHour = SuccessRate(speed) * ProductionRatePerHour(speed);
        double successPerMinute = successPerHour / 60;

        return (int)successPerMinute;

        throw new NotImplementedException("Please implement the (static) AssemblyLine.WorkingItemsPerMinute() method");
    }
}
