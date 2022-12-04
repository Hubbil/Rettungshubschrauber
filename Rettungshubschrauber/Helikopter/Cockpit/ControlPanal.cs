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

    private EnergyUnit _energyUnit;
    
    public ControlPanal(CentralUnit unit, EnergyUnit eunit)
    {
        MainRotorButton = new Button();
        TailRotorButton = new Button();
        AntiCollisionLight = new Button();
        LandingLight = new Button();
        LockDoorsButton = new Button();
        Knob = new RotaryKnob();
        CentralUnit  = unit;
        _energyUnit = eunit;
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
            AntiCollisionLight.IsOn = false;
            CentralUnit.DeActivateAntiCollisionLight();
        }
        else
        {
            AntiCollisionLight.IsOn = true;
            CentralUnit.ActivateAntiCollisionLight();
        }
    }

    public void SwitchLandingLightButton()
    {
        if (LandingLight.IsOn)
        {
            LandingLight.IsOn = false;
            CentralUnit.DeactivateLandingLight();
        }
        else
        {
            LandingLight.IsOn = true;
            CentralUnit.ActivateLandingLight();
        }
    }

    public void SwitchDoorButton()
    {
        if (LockDoorsButton.IsOn)
        {
            LockDoorsButton.IsOn = false;
            CentralUnit.UnlockBackDoors();
        }
        else
        {
            LockDoorsButton.IsOn = true;
            CentralUnit.LockBackDoors();
        }
    }

    public void TurnRotaryKnob(string state)
    {
        if (Knob.States.Contains(state))
        {
            Knob.State = state;
            _energyUnit.Mode = state;
        }
        else
        {
            Console.WriteLine($@"{state} ist kein valider Batteriestatus!");
        }
    }
}