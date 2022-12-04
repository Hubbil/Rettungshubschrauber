namespace Rettungshubschrauber.Helikopter.Technic.Drone;

public class CentralUnitDrone
{
    public CentralUnit unit;
    
    public MemoryCard MemoryCard { get; set; }
    
    public Camera Camera { get; set; }

    public CentralUnitDrone(CentralUnit unit,Camera cam)
    {
        this.unit = unit;
        MemoryCard = new MemoryCard();
        Camera = cam;
    }

    public void sendSection()
    {
        unit.analyzeSection(Camera.getSection());
    }
}