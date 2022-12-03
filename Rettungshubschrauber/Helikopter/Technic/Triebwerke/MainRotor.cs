using Rettungshubschrauber.Helikopter.Motors;

namespace Rettungshubschrauber.Helikopter.Triebwerke;

public class MainRotor
{
    public ElectricEngine Engine { get; set; }
    
    public int RPM { get; set; }
    
    public double Tilt { get; set; }
    
    public double SideTilt { get; set; }

    private static double MaxTilt = 5;

    private static double MaxSideTilt = 2.5;
    
    public Blade[] Blades { get; set; }

    public MainRotor()
    {
        Engine = new ElectricEngine();
        Tilt = 0;
        SideTilt = 0;
        RPM = 0;
        Blades = new Blade[5];
        for (int i = 0; i < 5; i++)
        {
            Blades[i] = new Blade();
        }
    }
}