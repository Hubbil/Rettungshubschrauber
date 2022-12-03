using Rettungshubschrauber.Helikopter.Cockpit;
using Rettungshubschrauber.Helikopter.Motors;

namespace Rettungshubschrauber.Helikopter.Triebwerke;

public class TailRotor
{
    public int RPM { get; set; }
    
    public ElectricEngine Engine { get; set; }
    
    public Direction RotatioDirection { get; set; }

    public TailRotor()
    {
        Engine = new ElectricEngine();
        RPM = 0;
    }
}