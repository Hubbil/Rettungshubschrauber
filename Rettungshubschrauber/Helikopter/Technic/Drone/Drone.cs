namespace Rettungshubschrauber.Helikopter.Technic.Drone;

public class Drone
{
    public CentralUnitDrone unit;
    
    public Camera Camera { get; set; }

    public Drone(CentralUnit unit, Section[] sections)
    {
        Camera = new Camera(sections);
        this.unit = new CentralUnitDrone(unit,Camera);
    }

    
}