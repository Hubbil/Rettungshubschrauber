namespace Rettungshubschrauber.Helikopter.Cabin;

public class SlideDoor
{
    public Boolean closed { get; set; }
    
    public Boolean Locked { get; set; }

    public SlideDoor()
    {
        closed = true;
        Locked = false;
    }
}