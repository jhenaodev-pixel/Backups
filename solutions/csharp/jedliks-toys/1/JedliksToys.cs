class RemoteControlCar
{
    private double _distance = 0;
    private int _battery = 100;
    
    public static RemoteControlCar Buy()
    {
        var car = new RemoteControlCar();
        return car;
    }

    public string DistanceDisplay()
    {
        return $"Driven {_distance} meters";
    }

    public string BatteryDisplay()
    {
        if(_battery != 0){
            return $"Battery at {_battery}%";
        }
        else{
            return "Battery empty";
        }
    }

    public void Drive()
    {
        if(_battery > 0 ){
            _distance += 20;
            _battery --;
        }
    }
}
