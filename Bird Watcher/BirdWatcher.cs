using System;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return new int[] {0, 2, 5, 3, 7, 8, 4};
    }

    public int Today()
    {
        return birdsPerDay[^1];
      // int birdsvisitedToday = birdsPerDay[birdsPerDay.Length - 1];
       // far return birdsvisitedToday;
    }

    public void IncrementTodaysCount()
    {
         birdsPerDay[^1]++;
    }

    public bool HasDayWithoutBirds()
    {
        bool dayWithoutBird = false;
        foreach (int bird in birdsPerDay)
        {
            if (bird == 0) 
                dayWithoutBird = true;            
        }
        return dayWithoutBird;
    }

    public int CountForFirstDays(int numberOfDays)
    {
       int birds = 0;
       for (int i = 0; i < numberOfDays; i++)
       {
           birds += birdsPerDay[i];
       }
    return birds;
    }

    public int BusyDays()
    {
        int numberofBusyDays = 0;
        foreach (int birds in birdsPerDay)
        {
        if (birds >= 5) numberofBusyDays += 1;    
        }
        return numberofBusyDays;
    }
}
