using Rettungshubschrauber.Helikopter.Components;
using Rettungshubschrauber.Helikopter.Technic;

namespace Rettungshubschrauber.Helikopter.Cockpit;

public class Cockpit
{
    public Door leftDoor { get; set; }
    
    public Door rightDoor { get; set; }
    
    public Seat leftSeat { get; set; }
    
    public Seat rightSeat { get; set; }
    
    public Display leftDisplay { get; set; }
    
    public Display rightDisplay { get; set; }
    
    public CyclicStick leftStick { get; set; }
    
    public CyclicStick RightStick { get; set; }
    
    public CollectivePitchControl leftPitchControl { get; set; }
    
    public CollectivePitchControl rightPitchControl { get; set; }
    
    public AntiTorguePadel[] LeftPadels { get; set; }
    
    public AntiTorguePadel[] RightPadels { get; set; }
    
    public ControlPanal leftPanal { get; set; }
    
    public ControlPanal rightPanal { get; set; }

    public Cockpit(CentralUnit centralUnit)
    {
        leftDoor = new Door();
        rightDoor = new Door();
        leftSeat = new Seat();
        rightSeat = new Seat();
        leftDisplay = new Display();
        rightDisplay = new Display();
        leftStick = new CyclicStick(centralUnit);
        RightStick = new CyclicStick(centralUnit);
        leftPitchControl = new CollectivePitchControl(centralUnit);
        rightPitchControl = new CollectivePitchControl(centralUnit);
        LeftPadels = new AntiTorguePadel[2];
        LeftPadels[0] = new AntiTorguePadel(centralUnit, Position.Left);
        LeftPadels[1] = new AntiTorguePadel(centralUnit, Position.Right);
        RightPadels = new AntiTorguePadel[2];
        RightPadels[0] = new AntiTorguePadel(centralUnit, Position.Left);
        RightPadels[1] = new AntiTorguePadel(centralUnit, Position.Right);
        leftPanal = new ControlPanal();
        rightPanal = new ControlPanal();
    }
}