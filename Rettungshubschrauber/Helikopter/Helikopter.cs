using Rettungshubschrauber.Helikopter.Technic;
using Rettungshubschrauber.Helikopter.Technic.Drone;
using Rettungshubschrauber.Helikopter.Triebwerke;

namespace Rettungshubschrauber.Helikopter;

public class Helikopter
{
    
    public string Id { get; }
    
    public string Type { get; }
    
    public string Uuid { get; }
    
    public CentralUnit CentralUnit { get; set; }
    
    public Cockpit.Cockpit Cockpit { get; set; }
    
    public Cabin.Cabin Cabin { get; set; }
    
    public MainRotor MainRotor { get; set; }
    
    public TailRotor TailRotor { get; set; }
    
    public AntiCollisionLight AntiCollisionLight { get; set; }
    
    public LandingLight LandingLight { get; set; }
    
    public EnergyUnit EnergyUnit { get; set; }
    
    public Drone Drone { get; set; }
    
    public int Height { get; set; }
    
    public int Speed { get; set; }
    
    public Helikopter()
    {
        Id = "D-MGHX";
        Type = "M145";
        Guid t = Guid.NewGuid();
        Uuid = t.ToString();
        Height = 0;
        Speed = 0;
        MainRotor = new MainRotor();
        TailRotor = new TailRotor();
        CentralUnit = new CentralUnit();
        EnergyUnit = new EnergyUnit();
        Cockpit = new Cockpit.Cockpit(CentralUnit, EnergyUnit);
        Cabin = new Cabin.Cabin();
        AntiCollisionLight = new AntiCollisionLight();
        LandingLight = new LandingLight();
        Drone = new Drone();
        CentralUnit.SetHeli(this);
    }

    public void Start()
    {
    }

    public void Flight(int distance)
    {
        
    }

    public void Stop()
    {
        if (Height == 0 && Speed == 0)
        {
            CentralUnit.Stop();
        }
        else
        {
            Console.WriteLine($@"Sie können den Helikopter während des Fluges nicht ausschalten!");
        }
    }
    
}