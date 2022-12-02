namespace Rettungshubschrauber.Helikopter.Triebwerke;

public class MainRotor
{
    public int RotationRate { get; set; }
    
    public double Tilt { get; set; }
    
    public double SideTilt { get; set; }

    private static double MaxTilt = 2.5;
    
    public Blade[] Blades { get; set; }

    public MainRotor()
    {
        Tilt = 0;
        SideTilt = 0;
        RotationRate = 0;
        Blades = new Blade[5];
        for (int i = 0; i < 5; i++)
        {
            Blades[i] = new Blade();
        }
    }
}