using System;

public class Lasagna
{
    int ExpectedMinutes = 40;
    int Preparation_Time_Per_Layer = 2;
    
    public int ExpectedMinutesInOven()
    {
        return ExpectedMinutes;
    }

    public int RemainingMinutesInOven(int UsedMinutes)
    {
        return (ExpectedMinutes - UsedMinutes);
    }

    public int PreparationTimeInMinutes(int no_of_layers)
    {
        // Console.WriteLine("Enter number of layers: ");
        // no_of_layers = Convert.ToInt32(Console.ReadLine());
        return (no_of_layers * Preparation_Time_Per_Layer);
    }

    public int ElapsedTimeInMinutes(int no_of_layers, int UsedMinutes)
    {
        return (PreparationTimeInMinutes(no_of_layers) + UsedMinutes);
    }
}
