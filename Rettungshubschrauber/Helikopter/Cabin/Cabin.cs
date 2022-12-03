using Rettungshubschrauber.Helikopter.Components;

namespace Rettungshubschrauber.Helikopter.Cabin;

public class Cabin
{
    public Seat LeftSeat { get; set; }
    
    public Seat RightSeat { get; set; }
    
    public SlideDoor LeftDoor { get; set; }
    
    public SlideDoor RightDoor { get; set; }
    
    public TransportUnit TransportUnit { get; set; }

    public Cabin()
    {
        LeftSeat = new Seat();
        RightSeat = new Seat();
        LeftDoor = new SlideDoor();
        RightDoor = new SlideDoor();
        TransportUnit = new TransportUnit();
    }
}