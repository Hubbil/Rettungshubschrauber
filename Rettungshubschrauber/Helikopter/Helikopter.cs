using Rettungshubschrauber.Helikopter.Technic;
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

    public Helikopter()
    {
        Id = "D-MGHX";
        Type = "M145";
        Guid t = Guid.NewGuid();
        Uuid = t.ToString();
        MainRotor = new MainRotor();
        TailRotor = new TailRotor();
        CentralUnit = new CentralUnit();
        Cockpit = new Cockpit.Cockpit(CentralUnit);
        Cabin = new Cabin.Cabin();
        CentralUnit.SetHeli(this);
    }
    
}