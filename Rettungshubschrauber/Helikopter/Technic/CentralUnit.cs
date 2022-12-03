using Rettungshubschrauber.Helikopter.Cockpit;
using Rettungshubschrauber.Helikopter.Triebwerke;

namespace Rettungshubschrauber.Helikopter.Technic;

public class CentralUnit
{
    private Helikopter _helikopter;

    public CentralUnit()
    {
        
    }

    public void SetHeli(Helikopter heli)
    {
        _helikopter = heli;
    }

    public void TiltMainRotor(double step, Boolean side)
    {
        if (side)
        {
            _helikopter.MainRotor.SideTilt = step;
        }
        else
        {
            _helikopter.MainRotor.Tilt = step;
        }
    }

    public void ChangeBladeTurnAngle(double angle)
    {
        foreach (Blade blade in _helikopter.MainRotor.Blades)
        {
            blade.TurnAngle = angle;
        }
    }

    public void ChangeTailRotorDirection(Direction direction)
    {
        _helikopter.TailRotor.RotatioDirection = direction;
    }

    public void ActivateMainRotor()
    {
        _helikopter.MainRotor.Engine.On();
        _helikopter.MainRotor.RPM = 600;
    }
    
    public void DeactivateMainRotor()
    {
        _helikopter.MainRotor.Engine.Off();
        _helikopter.MainRotor.RPM = 0;
    }
    
    public void ActivateTailRotor()
    {
        _helikopter.TailRotor.Engine.On();
        _helikopter.TailRotor.RPM = 600;
    }
    
    public void DeactivateTailRotor()
    {
        _helikopter.TailRotor.Engine.Off();
        _helikopter.TailRotor.RPM = 0;
    }
}