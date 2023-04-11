using System;

class RemoteControlCar
{
    int distanceDriven = 0;
    int percentage = 100;
    
    public static RemoteControlCar Buy()
    {
       return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
            return $"Driven {distanceDriven} meters";
    }

    public string BatteryDisplay()
    {
       if (percentage > 0) 
           return $"Battery at {percentage}%";
      else
        return "Battery empty";
    }

    public void Drive()
    {
        if (percentage > 0)
        {
            distanceDriven += 20;
            percentage -= 1;
        }
    }
}
