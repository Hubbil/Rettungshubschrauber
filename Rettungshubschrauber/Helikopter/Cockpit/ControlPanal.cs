using Rettungshubschrauber.Helikopter.Technic;

namespace Rettungshubschrauber.Helikopter.Cockpit;

public class ControlPanal
{
    public Button MainRotorButton { get; set; }
    
    public Button TailRotorButton { get; set; }
    
    public Button AntiCollisionLight { get; set; }
    
    public Button LandingLight { get; set; }
    
    public Button LockDoorsButton { get; set; }
    
    public RotaryKnob Knob { get; set; }

    private CentralUnit CentralUnit;
    
    public ControlPanal(CentralUnit unit)
    {
        MainRotorButton = new Button();
        TailRotorButton = new Button();
        AntiCollisionLight = new Button();
        LandingLight = new Button();
        LockDoorsButton = new Button();
        Knob = new RotaryKnob();
        CentralUnit  = unit;
    }

    public void SwitchMainRotorButton()
    {
        if (MainRotorButton.IsOn)
        {
            MainRotorButton.IsOn = false;
            CentralUnit.DeactivateMainRotor();
        }
        else
        {
            MainRotorButton.IsOn = true;
            CentralUnit.ActivateMainRotor();
        }
    }
    
    public void SwitchTailRotorButton()
    {
        if (TailRotorButton.IsOn)
        {
            TailRotorButton.IsOn = false;
            CentralUnit.DeactivateTailRotor();
        }
        else
        {
            TailRotorButton.IsOn = true;
            CentralUnit.ActivateTailRotor();
        }
    }

    public void SwitchAntiCollisionLightButton()
    {
        if (AntiCollisionLight.IsOn)
        {
            TailRotorButton.IsOn = false;
            CentralUnit.DeactivateTailRotor();
        }
        else
        {
            TailRotorButton.IsOn = true;
            CentralUnit.ActivateTailRotor();
        }
    }

    public void SwitchLandingLightButton()
    {
        if (TailRotorButton.IsOn)
        {
            TailRotorButton.IsOn = false;
            CentralUnit.DeactivateTailRotor();
        }
        else
        {
            TailRotorButton.IsOn = true;
            CentralUnit.ActivateTailRotor();
        }
    }

    public void SwitchDoorButton()
    {
        if (TailRotorButton.IsOn)
        {
            TailRotorButton.IsOn = false;
            CentralUnit.DeactivateTailRotor();
        }
        else
        {
            TailRotorButton.IsOn = true;
            CentralUnit.ActivateTailRotor();
        }
    }
}