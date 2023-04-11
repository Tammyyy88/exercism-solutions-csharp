using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if(speed == 0)
        {
            return 0.00D;
        }
        else if (speed <= 4)
        {
            return 1.00D;
        }
       else if (speed <= 8)
        {
            return 0.90D;
        }
        else if (speed == 9)
        {
            return 0.80D;
        }
       else if (speed == 10)
        {
            return 0.77D;
        }
        else
            return 0;
    }
    
    public static double ProductionRatePerHour(int speed)
    {
