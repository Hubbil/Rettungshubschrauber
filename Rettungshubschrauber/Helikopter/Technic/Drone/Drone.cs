namespace Rettungshubschrauber.Helikopter.Technic.Drone;

public class Drone
{
    public CentralUnitDrone unit;
    
    public Camera Camera { get; set; }

    public Drone(CentralUnit unit)
    {
        Camera = new Camera();
        this.unit = new CentralUnitDrone(unit,Camera);
    }

    
}