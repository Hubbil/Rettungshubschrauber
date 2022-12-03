namespace Rettungshubschrauber.Helikopter.Motors;

public class ElectricEngine
{
    public int RPM { get; set; }
    
    public Boolean IsOn { get; set; }

    public ElectricEngine()
    {
        RPM = 0;
        IsOn = false;
    }

    public void On()
    {
        IsOn = true;
    }

    public void Off()
    {
        IsOn = false;
    }
}