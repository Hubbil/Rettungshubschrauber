namespace Rettungshubschrauber.Helikopter.Technic.Drone;

public class Drone
{
    public Camera Camera { get; set; }
    
    public MemoryCard MemoryCard { get; set; }

    public Drone()
    {
        Camera = new Camera();
        MemoryCard = new MemoryCard();
    }
}