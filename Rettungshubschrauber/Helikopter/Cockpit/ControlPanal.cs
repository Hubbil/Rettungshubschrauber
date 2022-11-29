namespace Rettungshubschrauber.Helikopter.Cockpit;

public class ControlPanal
{
    public Button MainRotorButton { get; set; }
    
    public Button TailRotorButton { get; set; }
    
    public Button AntiCollisionLight { get; set; }
    
    public Button LandingLight { get; set; }
    
    public Button LockDoors { get; set; }
    
    public RotaryKnob Knob { get; set; }
    
    public ControlPanal()
    {
        MainRotorButton = new Button();
        TailRotorButton = new Button();
        AntiCollisionLight = new Button();
        LandingLight = new Button();
        LockDoors = new Button();
        Knob = new RotaryKnob();
    }
}