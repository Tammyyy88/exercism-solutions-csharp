using System;

class RemoteControlCar
{
    private int distanceDriven;
    private int percentage;
    
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
       if (percentage == 0)
        {
            return "Battery empty";
        }
        else
        {
            return $"Battery at {percentage}%";
        }
    }

    public void Drive()
    {

      
    }
}
